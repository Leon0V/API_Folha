using System.ComponentModel.DataAnnotations;

namespace API_Folha.Models
{
    public class RegData
    {
        public string EmployeeId { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "AAAAAAA {0} AAAAAA {1} and {2}.")]
        public int Month { get; set; }
        public int Year { get; set; }
        public int Workhours { get; set; }
        public double Value { get; set; }
    }
}