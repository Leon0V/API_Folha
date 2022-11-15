using API_Folha.Models;
using System;

namespace API_Folha
{
    public class PayRollFactory : IPayrollFactory
    {
        public Payroll CreatePayroll(Employee employee, int month, int year, int workhours, double value)
        {            
            return new Payroll
            {
                employee = employee,
                Month = month,
                Year = year,
                Workhours = workhours,
                Value = value
            };
        }
    }
}