using System;
using System.ComponentModel.DataAnnotations;

namespace API_Folha.Models
{
    public class UpdEmp
    {
        public string Name { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Birthdate { get; set; }
    }
}