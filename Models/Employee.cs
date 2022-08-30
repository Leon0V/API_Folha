using System;

namespace API_Folha.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}