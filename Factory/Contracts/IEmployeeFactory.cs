using System;
using API_Folha.Models;

namespace API_Folha
{
    public interface IEmployeeFactory
    {
        Employee CreateEmployee(string name, string cpf, DateTime birthdate);
    }
}