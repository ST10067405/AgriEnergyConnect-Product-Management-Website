using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Farmer> Farmers { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            // Ensured the database is created using the migration scripts
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

                        // Configure the relationship between AspNetUsers table and ApplicationUser entity
            modelBuilder.Entity<ApplicationUser>()
                .ToTable("AspNetUsers"); // Ensure ApplicationUser maps to AspNetUsers table

            // Seed roles
            string adminRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Farmer", NormalizedName = "FARMER" },
                new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Id = adminRoleId, Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );

            #region adminAccountSetup
            // Seed admin user
            string adminUserId = Guid.NewGuid().ToString();
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "AgriAdmin",
                NormalizedUserName = "ADMIN@AGRI.COM",
                Email = "admin@agri.com",
                NormalizedEmail = "ADMIN@AGRI.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Admin100"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser);

            // Assign admin role to admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminUserId
            });
            #endregion

            // Seed data for testing
            modelBuilder.Entity<Farmer>().HasData(
                new Farmer { Id = 1, Name = "John Doe" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apples", Category = "Fruit", ProductionDate = DateTime.Now.AddDays(-10), FarmerId = 1 }
            );
        }
    }
}
