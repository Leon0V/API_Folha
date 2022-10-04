using System;
using System.ComponentModel.DataAnnotations;

namespace API_Folha.Models
{
    public class RegEmp
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthdate { get; set; }
    }

}