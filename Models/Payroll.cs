using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Folha.Models
{
    public class Payroll
    {   
        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee employee { get; set; }

        [Key]
        public int Id { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Workhours { get; set; }
        public double Value { get; set; }
        public double Gross => getGross(); //Salário Bruto
        public double Net => getLiquid(); //Salário Líquido
        public double IncomeTax => getIncomeTax(); //Imposto de Renda
        public double SocialTax => getSocialTax();  //Inss
        public double Mortgage => getMortgage(); //FGTS

        private double getGross()
        {
            return Value * Workhours;
        }

        private double getIncomeTax()
        {
            if (Gross < 1903.98)
            {
                return (Gross * 0);
            }
            else if (Gross >= 1903.99 && Gross <= 2826.65)
            {
                return (Gross * 0.075);
            }
            else if (Gross >= 2826.66 && Gross <= 3751.05)
            {
                return (Gross * 0.15);
            }
            else if (Gross >= 3751.52 && Gross <= 4664.68)
            {
                return (Gross * 0.225);
            }
            else
            {
                return (Gross * 0.275);
            }

        }
        private double getSocialTax()
        {
            if (Gross <= 1693.72)
            {
                return (Gross * 0.08);
            }

            else if (Gross >= 1693.73 && Gross <= 2822.90)
            {
                return (Gross * 0.09);
            }

            else if (Gross >= 2822.91 && Gross <= 5645.80)
            {
                return (Gross * 0.11);
            }

            else
            {
                return 621.03;
            }

        }
        private double getMortgage()
        {
            return (Gross * 0.08);
        }

        private double getLiquid()
        {
            return (Gross - IncomeTax - SocialTax);
        }

    }
}