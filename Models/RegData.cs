using System.ComponentModel.DataAnnotations;

namespace API_Folha.Models
{
    public class RegData
    {
        public string Cpf { get; set; } //Cpf
        [Required]
        [Range(1, 12, ErrorMessage = "Mês necessita estar entre {1} and {2}.")]
        
        public int Month { get; set; }
        [Required]
        [Range(1990, 2050, ErrorMessage = "Ano necessita estar entre {1} and {2}.")]

        public int Year { get; set; }
        [Required]
        [Range(1, 720, ErrorMessage = "Horas de trabalho necessitam estar entre {1} and {2}.")]

        public int Workhours { get; set; }
        [Range(1, 10000000, ErrorMessage = "O Valor mínimo por hora necessita ser maior que {1} ")]
        
        public double Value { get; set; }
    }
}