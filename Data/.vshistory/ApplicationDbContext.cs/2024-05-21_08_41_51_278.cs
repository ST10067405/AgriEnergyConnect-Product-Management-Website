using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data for testing
            modelBuilder.Entity<Farmer>().HasData(
                new Farmer { Id = 1, Name = "John Doe", Email = "john@example.com", Password = "hashedpassword" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apples", Category = "Fruit", ProductionDate = DateTime.Now.AddDays(-10), FarmerId = 1 }
            );
        }
    }
}
