using System.Data.Entity;

namespace EFWithMySQL
{
    public class CustomerDataConext : DbContext
    {
        public CustomerDataConext(): base("DefaultConnectionString")
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}