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

            // Configuring the relationship between Product and ApplicationUser
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ApplicationUser)
                .WithMany()
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed data for roles
            string adminRoleId = Guid.NewGuid().ToString();
            string farmerRoleId = Guid.NewGuid().ToString();
            string employeeRoleId = Guid.NewGuid().ToString();
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = farmerRoleId, Name = "Farmer", NormalizedName = "FARMER" },
                new IdentityRole { Id = employeeRoleId, Name = "Employee", NormalizedName = "EMPLOYEE" },
                new IdentityRole { Id = adminRoleId, Name = "Administrator", NormalizedName = "ADMINISTRATOR" }
            );

            // Seed data for users
            #region Admin User
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

            #region Employee User
            // Seed admin user
            string employeeUserId = Guid.NewGuid().ToString();
            var employeeUser = new ApplicationUser
            {
                Id = employeeUserId,
                UserName = "AgriEmployee",
                FirstName = "Employee",
                LastName = "Agri",
                NormalizedUserName = "EMPLOYEE1@AGRI.COM",
                Email = "employee1@agri.com",
                NormalizedEmail = "EMPLOYEE1@AGRI.COM",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<ApplicationUser>().HashPassword(null, "Employee100"),
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<ApplicationUser>().HasData(employeeUser);

            // Assign admin role to admin user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = employeeRoleId,
                UserId = employeeUserId
            });
            #endregion

            #region Farmer User
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

            // Add the "Farmer" role to the user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = farmerRoleId,
                    UserId = farmerId
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Apples",
                    Category = "Fruit",
                    ProductionDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-10)),
                    UserId = farmerId
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 2,
                    Name = "Carrots",
                    Category = "Vegetables",
                    ProductionDate = DateOnly.FromDateTime(DateTime.Now.AddDays(-25)),
                    UserId = farmerId
                });
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 3,
                    Name = "Rice",
                    Category = "Grain",
                    ProductionDate = DateOnly.FromDateTime(DateTime.Now.AddDays(5)),
                    UserId = farmerId
                });
            #endregion
        }
    }
}
