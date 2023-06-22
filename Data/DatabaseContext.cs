using Microsoft.EntityFrameworkCore; //for DbContext
using NLOG_Employees_EF.Models.DomainModels;//to call Employee

namespace NLOG_Employees_EF.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; } //The whitespace is the table name
    }
}
