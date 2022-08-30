using System.Collections.Generic;
using System.Linq;
using API_Folha.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Folha.Controllers
{
    [ApiController]
    [Route("api/payroll")]

    public class PayrollController : ControllerBase
    {
        private static List<Payroll> payrolls = new List<Payroll>();

        //register

        [HttpPost]
        [Route("regPay")]
        public IActionResult RegPay([FromBody] RegData regData)
        {
            var employee = EmployeeController.employees.FirstOrDefault
            (
                u => u.Id.Equals(regData.EmployeeId)
            );
            if (employee == null)
                return NotFound();

            var payroll = new Payroll();
            payroll.employee = employee;
            payroll.Month = regData.Month;
            payroll.Year = regData.Year;
            payroll.Value = regData.Value;
            payroll.Workhours = regData.Workhours;
            payrolls.Add(payroll);
            return Created("", payroll);
        }

        //list

        [HttpGet]
        [Route("listPay")]
        public IActionResult ListPay()
        {
            return Ok(payrolls);
        }

    }
}