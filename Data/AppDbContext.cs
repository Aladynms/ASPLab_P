using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        private string DbPath { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "employees.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
        options.UseSqlite($"Data Source={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeEntity>().HasData(
                new EmployeeEntity() 
                { 
                    EmployeeId = 1,
                    Name = "Adam",
                    LastName = "Nowak",
                    PESEL = "12345678901",
                    Email = "adam@wsei.edu.pl",
                    Phone = "123456789",
                    Position = 1,
                    Branch = "Chief",
                    DateOfEmployment = new DateTime(2000, 10, 10) 
                },
                new EmployeeEntity() 
                { 
                    EmployeeId = 2,
                    Name = "Ewa",
                    LastName = "Nowak",
                    PESEL = "10987654321",
                    Email = "ewa@wsei.edu.pl",
                    Phone = "987654321",
                    Position = 2,
                    Branch = "Worker",
                    DateOfEmployment = new DateTime(2001, 11, 11),
                    DateOfDismissal = new DateTime(2011, 11, 11) 
                }
            );
        }
    }
}
