using System;
using System.ComponentModel.DataAnnotations;

namespace API_Folha.Models
{
    public class Employee
    {
        public string Name { get; set; }
        [Key]
        public int Id { get; set; }
        public string Cpf { get; set; }
        public DateTime Birthdate { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}