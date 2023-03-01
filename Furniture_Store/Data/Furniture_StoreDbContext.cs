using Furniture_Store.Models;
using Microsoft.EntityFrameworkCore;

namespace Furniture_Store.Data
{
    public class Furniture_StoreDbContext : DbContext
    {
        public Furniture_StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }





    }
}
