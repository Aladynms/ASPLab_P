using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Number = table.Column<string>(type: "TEXT", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Country = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
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
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
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
                name: "employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    PESEL = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: false),
                    Position = table.Column<int>(type: "INTEGER", nullable: false),
                    BranchId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfDismissal = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employees_branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "495544e7-7caa-469a-ab35-cfd14a35c146", "495544e7-7caa-469a-ab35-cfd14a35c146", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d9b0335e-7381-43ca-bcca-f86fd5c45bf2", "d9b0335e-7381-43ca-bcca-f86fd5c45bf2", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a25325e2-29bf-400d-86df-cf8e00c37ab0", 0, "cf61ecf5-d63f-4f2e-b1cf-253c0c9b2a6a", "admin@wsei.edu.pl", true, false, null, "ADMIN@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEKf83Uz7HZB2qr/JSnmiqxKYRZLsfb8EoOSB8ToqUf4T7ZuQKdB+cz8110w7MEIH0g==", null, false, "62811a37-4765-4036-aa23-5428d919d5b2", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ad613de7-3b6c-439a-b023-5c1e4f777d34", 0, "5f3ffa00-6947-4d9e-a311-5775191f6bc2", "user@wsei.edu.pl", true, false, null, "USER@WSEI.EDU.PL", "USER", "AQAAAAEAACcQAAAAEB7k2Zz3CXOOVaa2zZu2EbLq06ylC55iOHXMbUj1itWQ6v/6prvEGsUyjs1ycYIpFg==", null, false, "c53ca4a4-b744-4133-9945-ecf831d7aa5c", false, "user" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 1, "Firma XYZ", "Warszawa", "Polska", "123", "00-015", "mazowieckie", "Marszałkowska" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 2, "ABC Sp. z o.o.", "Kraków", "Polska", "7", "31-001", "małopolskie", "Wawel" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 3, "Inicjatywa Polska", "Gdańsk", "Polska", "22", "80-827", "pomorskie", "Długa" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 4, "Tech Innovators", "Wrocław", "Polska", "15", "50-101", "dolnośląskie", "Rynek" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 5, "Nowoczesne Rozwiązania", "Poznań", "Polska", "80", "61-809", "wielkopolskie", "Święty Marcin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "495544e7-7caa-469a-ab35-cfd14a35c146", "a25325e2-29bf-400d-86df-cf8e00c37ab0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d9b0335e-7381-43ca-bcca-f86fd5c45bf2", "ad613de7-3b6c-439a-b023-5c1e4f777d34" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 1, 1, null, new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "jan.kowalski@firmaxyz.com", "Kowalski", "Jan", "80010112345", "123456789", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna.nowak@firmaxyz.com", "Nowak", "Anna", "90020223456", "987654321", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 3, 2, null, new DateTime(2012, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michal.wisniewski@abc.com", "Wiśniewski", "Michał", "82030334567", "234567891", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 4, 2, new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "katarzyna.lewandowska@abc.com", "Lewandowska", "Katarzyna", "85040445678", "198765432", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 5, 3, null, new DateTime(2013, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "piotr.duda@inicjatywa.pl", "Duda", "Piotr", "83050556789", "543216789", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 6, 3, null, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "alicja.jankowska@inicjatywa.pl", "Jankowska", "Alicja", "84060667890", "876543210", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 7, 4, null, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "lukasz.kaminski@techinnovators.com", "Kamiński", "Łukasz", "81070778901", "654321098", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 8, 4, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "magdalena.zajac@techinnovators.com", "Zając", "Magdalena", "83080889012", "321098765", 5 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 9, 5, null, new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tomasz.piotrowski@nowoczesne.pl", "Piotrowski", "Tomasz", "84090990123", "432109876", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 10, 5, null, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "monika.adamczyk@nowoczesne.pl", "Adamczyk", "Monika", "87010101234", "210987654", 6 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 11, 1, null, new DateTime(2016, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "karolina.wojcik@firmaxyz.com", "Wójcik", "Karolina", "88020212345", "345678912", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 12, 1, new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "artur.kaczmarek@firmaxyz.com", "Kaczmarek", "Artur", "90030323456", "456789123", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 13, 2, null, new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "karol.zielinski@abc.com", "Zieliński", "Karol", "89040434567", "567891234", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 14, 2, null, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "natalia.walczak@abc.com", "Walczak", "Natalia", "91050545678", "678912345", 5 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 15, 3, null, new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "marcin.szymanski@inicjatywa.pl", "Szymański", "Marcin", "92060656789", "789123456", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 16, 3, null, new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "patrycja.debska@inicjatywa.pl", "Dębska", "Patrycja", "93070767890", "891234567", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 17, 4, null, new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "damian.pawlak@techinnovators.com", "Pawlak", "Damian", "94080878901", "912345678", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 18, 4, null, new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "aleksandra.mazur@techinnovators.com", "Mazur", "Aleksandra", "95090989012", "123456789", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 19, 5, null, new DateTime(2018, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "rafal.witkowski@nowoczesne.pl", "Witkowski", "Rafał", "96101090123", "234567891", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 20, 5, null, new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "wiktoria.baran@nowoczesne.pl", "Baran", "Wiktoria", "97111101234", "345678912", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 21, 1, null, new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "marta.lis@firmaxyz.com", "Lis", "Marta", "98121212345", "456789123", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 22, 1, null, new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "pawel.olszewski@firmaxyz.com", "Olszewski", "Paweł", "99010123456", "567891234", 5 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 23, 2, null, new DateTime(2018, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "joanna.krawczyk@abc.com", "Krawczyk", "Joanna", "00020234567", "678912345", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 24, 2, null, new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "kamil.piotrowicz@abc.com", "Piotrowicz", "Kamil", "01030345678", "789123456", 6 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 25, 3, null, new DateTime(2017, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "agnieszka.jastrzebska@inicjatywa.pl", "Jastrzębska", "Agnieszka", "02040456789", "891234567", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 26, 3, null, new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "dawid.grabowski@inicjatywa.pl", "Grabowski", "Dawid", "03050567890", "912345678", 5 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 27, 4, null, new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "klaudia.wojciechowska@techinnovators.com", "Wojciechowska", "Klaudia", "04060678901", "123456789", 4 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 28, 4, null, new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "szymon.nowicki@techinnovators.com", "Nowicki", "Szymon", "05070789012", "234567891", 6 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 29, 5, null, new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "aleksander.kaczmarczyk@nowoczesne.pl", "Kaczmarczyk", "Aleksander", "06080890123", "345678912", 3 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 30, 5, null, new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "kinga.grabowska@nowoczesne.pl", "Grabowska", "Kinga", "07090901234", "456789123", 5 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_BranchId",
                table: "employees",
                column: "BranchId");
        }

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
                name: "employees");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "branches");
        }
    }
}
