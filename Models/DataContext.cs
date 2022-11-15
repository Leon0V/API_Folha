using API_Folha.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Folha.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<IEmployee> Employees { get; set; }
        public DbSet<IPayroll> Payrolls { get; set; }
    }
}