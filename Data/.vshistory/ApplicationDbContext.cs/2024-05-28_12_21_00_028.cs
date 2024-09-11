using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnect.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
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

            // Configure the relationship between Product and ApplicationUser
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ApplicationUser)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

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
                FirstName = "Admin",
                LastName = "Admin",
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
            string farmerId = Guid.NewGuid().ToString();
            var farmerUser = new ApplicationUser
            {
                Id = farmerId,
                UserName = "JohnDoe",
                FirstName = "John",
                LastName = "Doe",
                NormalizedUserName = "JOHNDOE@AGRI.COM",
                Email = "john.doe@agri.com",
                NormalizedEmail = "JOHN.DOE@AGRI.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Farmer100"),
                SecurityStamp = string.Empty
            };
            modelBuilder.Entity<ApplicationUser>().HasData(farmerUser);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Apples",
                    Category = "Fruit",
                    ProductionDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-10)),
                    UserId = farmerId
                });
        }
    }
}
