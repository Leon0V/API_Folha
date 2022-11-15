using API_Folha.Models;
using System;

namespace API_Folha
{
    public class EmployeeFactory
    {
        public static IEmployee CreateEmployee(string name, string cpf, DateTime birthdate)
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