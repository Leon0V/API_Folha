using System.Collections.Generic;
using System.Linq;
using API_Folha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace API_Folha.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _context;
        public EmployeeController(DataContext context) =>
        _context = context;


        // register
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] RegEmp regEmp)
        {
            var employee = new Employee
            {
                Name = regEmp.Name,
                Birthdate = regEmp.Birthdate,
                Cpf = regEmp.Cpf
            };
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return Created("", employee);
        }

        // list
        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            return Ok(_context.Employees.ToList());
        }

        //search
        [HttpGet]
        [Route("search/{Cpf}")]
        public IActionResult Search([FromRoute] string Cpf)
        {

            Employee employee = _context.Employees.FirstOrDefault(x => x.Cpf == Cpf);
            if (employee == null)
                return NotFound();

            return Ok(employee);

        }

        // update
        [HttpPatch]
        [Route("update/{Cpf}")]
        public IActionResult Update([FromRoute] string Cpf, [FromBody] UpdEmp updEmp)
        {
            var employee = _context.Employees.FirstOrDefault(u => u.Cpf.Equals(Cpf));
            if (employee == null)
                return NotFound();


            employee.Birthdate = updEmp.Birthdate;
            employee.Name = updEmp.Name;
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return Ok();
        }

        //delete
        [HttpDelete]
        [Route("deleteCPF/{Cpf}")]
        public IActionResult DeleteCPF([FromRoute] string Cpf)
        {

            var employee = _context.Employees.FirstOrDefault(x => x.Cpf == Cpf);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();
            return Ok();

        }
    }

}
