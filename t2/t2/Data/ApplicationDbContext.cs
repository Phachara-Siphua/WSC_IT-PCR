using t2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Runtime;

namespace t2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) {      }

        public DbSet<Product>Products { get; set; }
        
        public DbSet<Customer>Customers { get; set; }

        public DbSet<Order>Orders { get; set; }
    }
}
