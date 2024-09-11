using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AgriEnergyConnect.Migrations
{
    /// <inheritdoc />
    public partial class DBScript : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c2008da-da0d-45b8-84c9-b9a4bd716c08", null, "Administrator", "ADMINISTRATOR" },
                    { "813c682f-ceac-40bc-bf65-70eb27a682b9", null, "Farmer", "FARMER" },
                    { "e3609ef4-0747-474c-b95a-ccade8c3fe66", null, "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2c54555f-efd4-4c35-91c8-fe9aad93a5a8", 0, "0d6df7a9-4a58-4c73-87c4-da7fd649c2de", "Admin@agri.com", true, "Admin", "Agri", false, null, "ADMIN@AGRI.COM", "AGRIADMIN", "AQAAAAIAAYagAAAAENoaA9/5YuFcK+J/VDbNMkF1diz4KJ5GVWnibh2Xd5l8JKmJ0CEv5wvVFc/oSBXdEw==", null, false, "", false, "AdminAgri" },
                    { "321178de-6314-4401-a216-d3c1bccc532b", 0, "b82f8fdc-e8a0-4ff6-9bad-25ceed2c34f8", "FarmerJack@agri.com", true, "Farmer", "Jack", false, null, "FARMERJACK@AGRI.COM", "FARMERJACK", "AQAAAAIAAYagAAAAEFkbriovaNlsHG2S5d6je9yJQHpvm3SbnBk9JvAZfAHi+S8urZFoxaOydmqu4NzVtw==", null, false, "", false, "FarmerJack" },
                    { "4f3a22c5-cc78-41d5-ad53-cbf1c5a36957", 0, "bc380cea-baa6-48de-9b23-a254cbd7e785", "Employee1@agri.com", true, "Employee1", "Agri", false, null, "EMPLOYEE1@AGRI.COM", "EMPLOYEE1", "AQAAAAIAAYagAAAAEJZcENuQbrsWy703jaFH/uWjGPn6zg/HeCgiCJBFk65UKxg6sWkTKfLuw/94iZ7UdA==", null, false, "", false, "Employee1" },
                    { "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4", 0, "510bc8aa-9412-434b-89a8-4ceb38bab61d", "FarmerJane@agri.com", true, "Farmer", "Jane", false, null, "FARMERJANE@AGRI.COM", "FARMERJANE", "AQAAAAIAAYagAAAAEEmkPPxx4U8VRg/VP7oVfXR9yDbPSf0O3B3wgXzsLXuM9Ks9XxWZHun4SFBby1ne+w==", null, false, "", false, "FarmerJane" },
                    { "a1fc8e8e-9373-43d3-9578-2e36727a678b", 0, "b43a0505-5735-49b0-9b93-d0dca14b76d5", "FarmerJohn@agri.com", true, "Farmer", "John", false, null, "FARMERJOHN@AGRI.COM", "FARMERJOHN", "AQAAAAIAAYagAAAAED9+kmrDjbUZ7hbbiLLDQKyIc95dL7mMXYeQJnepHmYNAHxdQEyM69L3mOW9v1K1RA==", null, false, "", false, "FarmerJohn" },
                    { "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64", 0, "aa88f67e-3f8d-495e-abb9-2dc15dcc1b3e", "FarmerSarah@agri.com", true, "Farmer", "Sarah", false, null, "FARMERSARAH@AGRI.COM", "FARMERSARAH", "AQAAAAIAAYagAAAAEAaE1mWJ/yZOVrQaG7ZO7BkdSlfXja1Tv8jf47fnem3kJLqvf+VNBEUrwIYVa0c7XQ==", null, false, "", false, "FarmerSarah" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "6c2008da-da0d-45b8-84c9-b9a4bd716c08", "2c54555f-efd4-4c35-91c8-fe9aad93a5a8" },
                    { "813c682f-ceac-40bc-bf65-70eb27a682b9", "321178de-6314-4401-a216-d3c1bccc532b" },
                    { "e3609ef4-0747-474c-b95a-ccade8c3fe66", "4f3a22c5-cc78-41d5-ad53-cbf1c5a36957" },
                    { "813c682f-ceac-40bc-bf65-70eb27a682b9", "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                    { "813c682f-ceac-40bc-bf65-70eb27a682b9", "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                    { "813c682f-ceac-40bc-bf65-70eb27a682b9", "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Category", "Name", "ProductionDate", "UserId" },
                values: new object[,]
                {
                    { 1, "Fruit", "Apples", new DateOnly(2024, 5, 18), "321178de-6314-4401-a216-d3c1bccc532b" },
                    { 2, "Vegetables", "Carrots", new DateOnly(2024, 5, 3), "321178de-6314-4401-a216-d3c1bccc532b" },
                    { 3, "Grain", "Rice", new DateOnly(2024, 6, 2), "321178de-6314-4401-a216-d3c1bccc532b" },
                    { 4, "Fruit", "Oranges", new DateOnly(2024, 5, 20), "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                    { 5, "Vegetables", "Potatoes", new DateOnly(2024, 6, 5), "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                    { 6, "Grain", "Wheat", new DateOnly(2024, 6, 10), "7d8ab917-8e28-4b3f-87c3-31f0cc10d5c4" },
                    { 7, "Fruit", "Bananas", new DateOnly(2024, 6, 7), "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                    { 8, "Vegetables", "Tomatoes", new DateOnly(2024, 5, 25), "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                    { 9, "Grain", "Barley", new DateOnly(2024, 6, 15), "a1fc8e8e-9373-43d3-9578-2e36727a678b" },
                    { 10, "Fruit", "Strawberries", new DateOnly(2024, 6, 1), "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" },
                    { 11, "Vegetables", "Cabbages", new DateOnly(2024, 6, 20), "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" },
                    { 12, "Grain", "Oats", new DateOnly(2024, 5, 30), "cf5f7b1b-17e8-4e4e-bf6d-44c2b5f5be64" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UserId",
                table: "Products",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
