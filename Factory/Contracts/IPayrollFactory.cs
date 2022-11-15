using System;
using API_Folha.Models;

namespace API_Folha
{
    public interface IPayrollFactory
    {
        Payroll CreatePayroll(Employee employee, int Month, int Year, int Workhours, double Value);
    }
}