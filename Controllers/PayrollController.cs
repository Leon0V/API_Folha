using System.Collections.Generic;
using System.Linq;
using API_Folha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Folha.Controllers
{
    [ApiController]
    [Route("api/payroll")]

    public class PayrollController : ControllerBase
    {
        private readonly DataContext _context;
        public PayrollController(DataContext context) =>
        _context = context;


        //register

        [HttpPost]
        [Route("regPay")]
        public IActionResult RegPay([FromBody] RegData regData)
        {
            var employees = _context.Employees.FirstOrDefault(x => x.Cpf == regData.Cpf);
            if (employees != null)
            {
                Payroll payroll = new Payroll
                {
                    employee = employees,
                    Month = regData.Month,
                    Year = regData.Year,
                    Value = regData.Value,
                    Workhours = regData.Workhours
                };
                _context.Payrolls.Add(payroll);
                _context.SaveChanges();
                return Created("", payroll);

            }
            return BadRequest("Funcionário não encontrado.");

        }

        //list

        [HttpGet]
        [Route("listPay")]
        public IActionResult ListPay()
        {
            return Ok(_context.Payrolls.Include(x => x.employee).ToList());
        }

        [HttpGet]
        [Route("searchPay/{Cpf}/{Month}/{Year}")]
        public IActionResult SearchPay([FromRoute] string Cpf, int Month, int Year)
        {
            var employee = _context.Employees.FirstOrDefault(u => u.Cpf.Equals(Cpf));
            if (employee != null)
            {
                var payroll = _context.Payrolls.Include(x => x.employee).Where(x => x.Month == Month && x.Year == Year);

                return Ok(payroll);
            }
            return BadRequest("Folha não encontrada!");

        }


        //mes ano
        [HttpGet]
        [Route("filterPay/{Month}/{Year}")]
        public IActionResult FilterPay([FromRoute] int Month, int Year)
        {

            var payroll = _context.Payrolls.Include(x => x.employee).Where(x => x.Month == Month && x.Year == Year);
            return Ok(payroll);


        }

    }
}