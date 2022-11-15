using API_Folha.Models;
using System;

namespace API_Folha
{
    public class EmployeeFactory : IEmployeeFactory
    {
        public Employee CreateEmployee(string name, string cpf, DateTime birthdate)
        {            
            return new Employee
            {
                Name = name,
                Birthdate = birthdate,
                Cpf = cpf
            };
        }
    }
}