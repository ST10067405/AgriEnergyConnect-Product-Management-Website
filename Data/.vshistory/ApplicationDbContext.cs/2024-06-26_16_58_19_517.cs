using AgriEnergyConnect.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

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
            string adminUserId = "2c54555f-efd4-4c35-91c8-fe9aad93a5a8";
            var adminUser = new ApplicationUser
            {
                Id = adminUserId,
                UserName = "AdminAgri",
                FirstName = "Admin",
                LastName = "Agri",
                NormalizedUserName = "AGRIADMIN",
                Email = "Admin@agri.com",
                NormalizedEmail = "ADMIN@AGRI.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAENoaA9/5YuFcK+J/VDbNMkF1diz4KJ5GVWnibh2Xd5l8JKmJ0CEv5wvVFc/oSBXdEw==",
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
            // Seed employee user
            string employeeUserId = "4f3a22c5-cc78-41d5-ad53-cbf1c5a36957";
            var employeeUser = new ApplicationUser
            {
                Id = employeeUserId,
                UserName = "Employee1",
                FirstName = "Employee1",
                LastName = "Agri",
                NormalizedUserName = "EMPLOYEE1",
                Email = "Employee1@agri.com",
                NormalizedEmail = "EMPLOYEE1@AGRI.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAIAAYagAAAAEJZcENuQbrsWy703jaFH/uWjGPn6zg/HeCgiCJBFk65UKxg6sWkTKfLuw/94iZ7UdA==",
                SecurityStamp = string.Empty
            };

            modelBuilder.Entity<ApplicationUser>().HasData(employeeUser);

            // Assign employee role to employee user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = employeeRoleId,
                UserId = employeeUserId
            });
            #endregion

            #region Farmer Users
            // Seed farmer users and their products
            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "321178de-6314-4401-a216-d3c1bccc532b",
                    UserName = "FarmerJack",
                    FirstName = "Farmer",
                    LastName = "Jack",
                    NormalizedUserName = "FARMERJACK",
                    Email = "FarmerJack@agri.com",
                    NormalizedEmail = "FARMERJACK@AGRI.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEB92rfg+QPZ3M/Ffx7/HlFqn5FmYJY4UNRizWhrJ5oDGbZ/F/wTi934x4VnosCrq/A==",
                    SecurityStamp = string.Empty
                },
                new ApplicationUser
                {
                    Id = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4",
                    UserName = "FarmerJane",
                    FirstName = "Farmer",
                    LastName = "Jane",
                    NormalizedUserName = "FARMERJANE",
                    Email = "FarmerJane@agri.com",
                    NormalizedEmail = "FARMERJANE@AGRI.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEB92rfg+QPZ3M/Ffx7/HlFqn5FmYJY4UNRizWhrJ5oDGbZ/F/wTi934x4VnosCrq/A==",
                    SecurityStamp = string.Empty
                },
                new ApplicationUser
                {
                    Id = "a1fc8e8e-9373-43d3-9578-2e36727a678b",
                    UserName = "FarmerJohn",
                    FirstName = "Farmer",
                    LastName = "John",
                    NormalizedUserName = "FARMERJOHN",
                    Email = "FarmerJohn@agri.com",
                    NormalizedEmail = "FARMERJOHN@AGRI.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEB92rfg+QPZ3M/Ffx7/HlFqn5FmYJY4UNRizWhrJ5oDGbZ/F/wTi934x4VnosCrq/A==",
                    SecurityStamp = string.Empty
                },
                new ApplicationUser
                {
                    Id = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64",
                    UserName = "FarmerSarah",
                    FirstName = "Farmer",
                    LastName = "Sarah",
                    NormalizedUserName = "FARMERSARAH",
                    Email = "FarmerSarah@agri.com",
                    NormalizedEmail = "FARMERSARAH@AGRI.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEB92rfg+QPZ3M/Ffx7/HlFqn5FmYJY4UNRizWhrJ5oDGbZ/F/wTi934x4VnosCrq/A==",
                    SecurityStamp = string.Empty
                }
            );

            // Assign farmer role to each farmer user
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = farmerRoleId, UserId = "321178de-6314-4401-a216-d3c1bccc532b" },
                new IdentityUserRole<string> { RoleId = farmerRoleId, UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                new IdentityUserRole<string> { RoleId = farmerRoleId, UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                new IdentityUserRole<string> { RoleId = farmerRoleId, UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" }
            );

            // Seed products for each farmer
            modelBuilder.Entity<Product>().HasData(
                // Products for FarmerJack
                new Product { ProductId = 1, Name = "Apples", Category = "Fruit", ProductionDate = new DateOnly(2024, 5, 18), UserId = "321178de-6314-4401-a216-d3c1bccc532b" },
                new Product { ProductId = 2, Name = "Carrots", Category = "Vegetables", ProductionDate = new DateOnly(2024, 5, 3), UserId = "321178de-6314-4401-a216-d3c1bccc532b" },
                new Product { ProductId = 3, Name = "Rice", Category = "Grain", ProductionDate = new DateOnly(2024, 6, 2), UserId = "321178de-6314-4401-a216-d3c1bccc532b" },
                // Products for FarmerJane
                new Product { ProductId = 4, Name = "Oranges", Category = "Fruit", ProductionDate = new DateOnly(2024, 5, 20), UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                new Product { ProductId = 5, Name = "Potatoes", Category = "Vegetables", ProductionDate = new DateOnly(2024, 6, 5), UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                new Product { ProductId = 6, Name = "Wheat", Category = "Grain", ProductionDate = new DateOnly(2024, 6, 10), UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                // Products for FarmerJohn
                new Product { ProductId = 7, Name = "Bananas", Category = "Fruit", ProductionDate = new DateOnly(2024, 6, 7), UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                new Product { ProductId = 8, Name = "Tomatoes", Category = "Vegetables", ProductionDate = new DateOnly(2024, 5, 25), UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                new Product { ProductId = 9, Name = "Barley", Category = "Grain", ProductionDate = new DateOnly(2024, 6, 15), UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                // Products for FarmerSarah
                new Product { ProductId = 10, Name = "Strawberries", Category = "Fruit", ProductionDate = new DateOnly(2024, 6, 1), UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" },
                new Product { ProductId = 11, Name = "Cabbages", Category = "Vegetables", ProductionDate = new DateOnly(2024, 6, 20), UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" },
                new Product { ProductId = 12, Name = "Oats", Category = "Grain", ProductionDate = new DateOnly(2024, 5, 30), UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" }
            );
            #endregion
        }
    }
}
