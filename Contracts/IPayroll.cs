using API_Folha.Models;

namespace API_Folha
{
    public interface IPayroll
    {
        int EmployeeId { get; set; }
        Employee employee { get; set; }
        int Id { get; set; }
        int Month { get; set; }
        int Year { get; set; }
        int Workhours { get; set; }
        double Value { get; set; }
        double Gross { get; }
        double Net { get; }
        double IncomeTax { get; }
        double SocialTax { get; }
        double Mortgage { get; }


    }
}