using Microsoft.EntityFrameworkCore;

namespace DataAnnotation.Data
{
    public class Context : DbContext
    {

        DbSet<Employee> employees { get; set; }
        DbSet<Customer> customer { get; set; }
        DbSet<Address> addresses { get; set; }
        DbSet<ServiceRequest> servicerequest { get; set; }
        DbSet<ServiceState> servicestate { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=Service;Trusted_Connection=True;");
        }


    }
}
