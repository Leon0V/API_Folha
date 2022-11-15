using System;

namespace API_Folha
{
    public interface IEmployee
    {
        string Name { get; set; }
        int Id { get; set; }
        string Cpf { get; set; }
        DateTime Birthdate { get; set; }
        DateTime CreationTime { get; set; }
    }
}