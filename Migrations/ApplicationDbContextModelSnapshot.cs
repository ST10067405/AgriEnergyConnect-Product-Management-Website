﻿// <auto-generated />
using System;
using AgriEnergyConnect.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AgriEnergyConnect.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AgriEnergyConnect.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "2c54555f-efd4-4c35-91c8-fe9aad93a5a8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0d6df7a9-4a58-4c73-87c4-da7fd649c2de",
                            Email = "Admin@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Agri",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@AGRI.COM",
                            NormalizedUserName = "AGRIADMIN",
                            PasswordHash = "AQAAAAIAAYagAAAAENoaA9/5YuFcK+J/VDbNMkF1diz4KJ5GVWnibh2Xd5l8JKmJ0CEv5wvVFc/oSBXdEw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "AdminAgri"
                        },
                        new
                        {
                            Id = "4f3a22c5-cc78-41d5-ad53-cbf1c5a36957",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bc380cea-baa6-48de-9b23-a254cbd7e785",
                            Email = "Employee1@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Employee1",
                            LastName = "Agri",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE1@AGRI.COM",
                            NormalizedUserName = "EMPLOYEE1",
                            PasswordHash = "AQAAAAIAAYagAAAAEJZcENuQbrsWy703jaFH/uWjGPn6zg/HeCgiCJBFk65UKxg6sWkTKfLuw/94iZ7UdA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Employee1"
                        },
                        new
                        {
                            Id = "321178de-6314-4401-a216-d3c1bccc532b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b82f8fdc-e8a0-4ff6-9bad-25ceed2c34f8",
                            Email = "FarmerJack@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Farmer",
                            LastName = "Jack",
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMERJACK@AGRI.COM",
                            NormalizedUserName = "FARMERJACK",
                            PasswordHash = "AQAAAAIAAYagAAAAEFkbriovaNlsHG2S5d6je9yJQHpvm3SbnBk9JvAZfAHi+S8urZFoxaOydmqu4NzVtw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "FarmerJack"
                        },
                        new
                        {
                            Id = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "510bc8aa-9412-434b-89a8-4ceb38bab61d",
                            Email = "FarmerJane@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Farmer",
                            LastName = "Jane",
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMERJANE@AGRI.COM",
                            NormalizedUserName = "FARMERJANE",
                            PasswordHash = "AQAAAAIAAYagAAAAEEmkPPxx4U8VRg/VP7oVfXR9yDbPSf0O3B3wgXzsLXuM9Ks9XxWZHun4SFBby1ne+w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "FarmerJane"
                        },
                        new
                        {
                            Id = "a1fc8e8e-9373-43d3-9578-2e36727a678b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b43a0505-5735-49b0-9b93-d0dca14b76d5",
                            Email = "FarmerJohn@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Farmer",
                            LastName = "John",
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMERJOHN@AGRI.COM",
                            NormalizedUserName = "FARMERJOHN",
                            PasswordHash = "AQAAAAIAAYagAAAAED9+kmrDjbUZ7hbbiLLDQKyIc95dL7mMXYeQJnepHmYNAHxdQEyM69L3mOW9v1K1RA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "FarmerJohn"
                        },
                        new
                        {
                            Id = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aa88f67e-3f8d-495e-abb9-2dc15dcc1b3e",
                            Email = "FarmerSarah@agri.com",
                            EmailConfirmed = true,
                            FirstName = "Farmer",
                            LastName = "Sarah",
                            LockoutEnabled = false,
                            NormalizedEmail = "FARMERSARAH@AGRI.COM",
                            NormalizedUserName = "FARMERSARAH",
                            PasswordHash = "AQAAAAIAAYagAAAAEAaE1mWJ/yZOVrQaG7ZO7BkdSlfXja1Tv8jf47fnem3kJLqvf+VNBEUrwIYVa0c7XQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "FarmerSarah"
                        });
                });

            modelBuilder.Entity("AgriEnergyConnect.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("ProductionDate")
                        .HasColumnType("date");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Fruit",
                            Name = "Apples",
                            ProductionDate = new DateOnly(2024, 5, 18),
                            UserId = "321178de-6314-4401-a216-d3c1bccc532b"
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Vegetables",
                            Name = "Carrots",
                            ProductionDate = new DateOnly(2024, 5, 3),
                            UserId = "321178de-6314-4401-a216-d3c1bccc532b"
                        },
                        new
                        {
                            ProductId = 3,
                            Category = "Grain",
                            Name = "Rice",
                            ProductionDate = new DateOnly(2024, 6, 2),
                            UserId = "321178de-6314-4401-a216-d3c1bccc532b"
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "Fruit",
                            Name = "Oranges",
                            ProductionDate = new DateOnly(2024, 5, 20),
                            UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4"
                        },
                        new
                        {
                            ProductId = 5,
                            Category = "Vegetables",
                            Name = "Potatoes",
                            ProductionDate = new DateOnly(2024, 6, 5),
                            UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4"
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Grain",
                            Name = "Wheat",
                            ProductionDate = new DateOnly(2024, 6, 10),
                            UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4"
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Fruit",
                            Name = "Bananas",
                            ProductionDate = new DateOnly(2024, 6, 7),
                            UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b"
                        },
                        new
                        {
                            ProductId = 8,
                            Category = "Vegetables",
                            Name = "Tomatoes",
                            ProductionDate = new DateOnly(2024, 5, 25),
                            UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b"
                        },
                        new
                        {
                            ProductId = 9,
                            Category = "Grain",
                            Name = "Barley",
                            ProductionDate = new DateOnly(2024, 6, 15),
                            UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b"
                        },
                        new
                        {
                            ProductId = 10,
                            Category = "Fruit",
                            Name = "Strawberries",
                            ProductionDate = new DateOnly(2024, 6, 1),
                            UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64"
                        },
                        new
                        {
                            ProductId = 11,
                            Category = "Vegetables",
                            Name = "Cabbages",
                            ProductionDate = new DateOnly(2024, 6, 20),
                            UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64"
                        },
                        new
                        {
                            ProductId = 12,
                            Category = "Grain",
                            Name = "Oats",
                            ProductionDate = new DateOnly(2024, 5, 30),
                            UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "813c682f-ceac-40bc-bf65-70eb27a682b9",
                            Name = "Farmer",
                            NormalizedName = "FARMER"
                        },
                        new
                        {
                            Id = "e3609ef4-0747-474c-b95a-ccade8c3fe66",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "6c2008da-da0d-45b8-84c9-b9a4bd716c08",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "2c54555f-efd4-4c35-91c8-fe9aad93a5a8",
                            RoleId = "6c2008da-da0d-45b8-84c9-b9a4bd716c08"
                        },
                        new
                        {
                            UserId = "4f3a22c5-cc78-41d5-ad53-cbf1c5a36957",
                            RoleId = "e3609ef4-0747-474c-b95a-ccade8c3fe66"
                        },
                        new
                        {
                            UserId = "321178de-6314-4401-a216-d3c1bccc532b",
                            RoleId = "813c682f-ceac-40bc-bf65-70eb27a682b9"
                        },
                        new
                        {
                            UserId = "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4",
                            RoleId = "813c682f-ceac-40bc-bf65-70eb27a682b9"
                        },
                        new
                        {
                            UserId = "a1fc8e8e-9373-43d3-9578-2e36727a678b",
                            RoleId = "813c682f-ceac-40bc-bf65-70eb27a682b9"
                        },
                        new
                        {
                            UserId = "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64",
                            RoleId = "813c682f-ceac-40bc-bf65-70eb27a682b9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AgriEnergyConnect.Models.Product", b =>
                {
                    b.HasOne("AgriEnergyConnect.Data.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AgriEnergyConnect.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AgriEnergyConnect.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgriEnergyConnect.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AgriEnergyConnect.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
