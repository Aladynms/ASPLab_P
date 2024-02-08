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
                    Branch = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfEmployment = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateOfDismissal = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Branch", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 1, "Chief", null, new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "adam@wsei.edu.pl", "Nowak", "Adam", "12345678901", "123456789", 1 });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "EmployeeId", "Branch", "DateOfDismissal", "DateOfEmployment", "Email", "LastName", "Name", "PESEL", "Phone", "Position" },
                values: new object[] { 2, "Worker", new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "ewa@wsei.edu.pl", "Nowak", "Ewa", "10987654321", "987654321", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
