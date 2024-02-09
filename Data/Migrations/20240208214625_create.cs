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
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 1, "WSEI", "Kraków", "Polska", "17", "31-150", "małopolskie", "Św. Filipa" });

            migrationBuilder.InsertData(
                table: "branches",
                columns: new[] { "BranchId", "Title", "Address_City", "Address_Country", "Address_Number", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 2, "BackHouse", "Warszawa", "Polska", "45/6", "00-057", "mazowieckie", "Krowoderska" });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 1, 1, null, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Nowak", "Adam", "12345678901", "123456789", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 2, 1, new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ewa@wsei.edu.pl", "Nowak", "Ewa", "10987654321", "987654321", 2 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 3, 2, null, new DateTime(2005, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Trud", "Michał", "23456789012", "234567891", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "BranchId", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 4, 2, new DateTime(2014, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "ewa@wsei.edu.pl", "Nowak", "Ewa", "210987654321", "198765432", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_employees_BranchId",
                table: "employees",
                column: "BranchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "branches");
        }
    }
}
