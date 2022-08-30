using System.Collections.Generic;
using System.Linq;
using API_Folha.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folha.Controllers
{
    [ApiController]
    [Route("api/employee")]
    public class EmployeeController : ControllerBase
    {
        public static List<Employee> employees = new List<Employee>();

        // register

        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] Employee employee)
        {
            employees.Add(employee);
            return Created("", employee);
        }

        // list

        [HttpGet]
        [Route("list")]
        public IActionResult List()
        {
            return Ok(employees);
        }

        //search

        [HttpGet]
        [Route("search/{id}")]
        public IActionResult Search([FromRoute] string id)
        {
            Employee employee = employees.FirstOrDefault
            (
                u => u.Id.Equals(id)
            );
            if (employee == null)
                return NotFound();

            return Ok(employee);

        }
    }
}