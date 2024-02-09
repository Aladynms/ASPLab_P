using Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<EmployeeEntity> Employees { get; set; }
        public DbSet<BranchEntity> Branches { get; set; }
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
            base.OnModelCreating(modelBuilder);

            // utworzenie id
            string ADMIN_ID = Guid.NewGuid().ToString();
            string ADMIN_ROLE_ID = Guid.NewGuid().ToString();

            string USER_ID = Guid.NewGuid().ToString();
            string USER_ROLE_ID = Guid.NewGuid().ToString();

            // utworzenie ról
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "admin",
                    NormalizedName = "ADMIN",
                    Id = ADMIN_ROLE_ID,
                    ConcurrencyStamp = ADMIN_ROLE_ID
                });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole()
                {
                    Name = "user",
                    NormalizedName = "USER",
                    Id = USER_ROLE_ID,
                    ConcurrencyStamp = USER_ROLE_ID
                });

            // utworzenie użytkowników
            var admin = new IdentityUser()
            {
                Id = ADMIN_ID,
                Email = "admin@wsei.edu.pl",
                NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "admin",
                NormalizedUserName = "ADMIN"
            };

            var user = new IdentityUser()
            {
                Id = USER_ID,
                Email = "user@wsei.edu.pl",
                NormalizedEmail = "USER@WSEI.EDU.PL",
                EmailConfirmed = true,
                UserName = "user",
                NormalizedUserName = "USER"
            };

            // haszowanie haseł
            PasswordHasher<IdentityUser> ph = new PasswordHasher<IdentityUser>();

            admin.PasswordHash = ph.HashPassword(admin, "admin");
            user.PasswordHash = ph.HashPassword(user, "user");

            // dodanie użytkowników
            modelBuilder.Entity<IdentityUser>().HasData(admin);
            modelBuilder.Entity<IdentityUser>().HasData(user);

            //przypisanie administratorowi roli admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = ADMIN_ROLE_ID,
                    UserId = ADMIN_ID,
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = USER_ROLE_ID,
                    UserId = USER_ID,
                });

            // Entity
            modelBuilder.Entity<BranchEntity>()
            .OwnsOne(e => e.Address);

            modelBuilder.Entity<EmployeeEntity>()
                .HasOne(e => e.Branch)
                .WithMany(o => o.Employees)
                .HasForeignKey(e => e.BranchId);

            modelBuilder.Entity<BranchEntity>().HasData(
                new BranchEntity()
                {
                    BranchId = 1,
                    Title = "WSEI"
                },
                new BranchEntity()
                {
                    BranchId = 2,
                    Title = "BackHouse"
                }
            );

            modelBuilder.Entity<BranchEntity>()
               .OwnsOne(e => e.Address)
               .HasData(
                   new {
                       BranchEntityBranchId = 1,
                       City = "Kraków",
                       Street = "Św. Filipa",
                       Number = "17",
                       PostalCode = "31-150",
                       Region = "małopolskie",
                       Country = "Polska"
                   },
                   new {
                       BranchEntityBranchId = 2,
                       City = "Warszawa",
                       Street = "Krowoderska",
                       Number = "45/6",
                       PostalCode = "00-057",
                       Region = "mazowieckie",
                       Country = "Polska"
                   }
            );


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
                    BranchId = 1,
                    DateOfEmployment = new DateTime(2000, 10, 10) 
                },
                new EmployeeEntity() 
                { 
                    EmployeeId = 2,
                    Name = "Ewa",
                    LastName = "Kocioł",
                    PESEL = "10987654321",
                    Email = "ewa@wsei.edu.pl",
                    Phone = "987654321",
                    Position = 2,
                    BranchId = 1,
                    DateOfEmployment = new DateTime(2001, 11, 11),
                    DateOfDismissal = new DateTime(2011, 11, 11)
                },
                new EmployeeEntity()
                {
                    EmployeeId = 3,
                    Name = "Michał",
                    LastName = "Trud",
                    PESEL = "23456789012",
                    Email = "adam@wsei.edu.pl",
                    Phone = "234567891",
                    Position = 1,
                    BranchId = 2,
                    DateOfEmployment = new DateTime(2005, 12, 15)
                },
                new EmployeeEntity()
                {
                    EmployeeId = 4,
                    Name = "Iwo",
                    LastName = "Dran",
                    PESEL = "210987654321",
                    Email = "ewa@wsei.edu.pl",
                    Phone = "198765432",
                    Position = 2,
                    BranchId = 2,
                    DateOfEmployment = new DateTime(2007, 11, 17),
                    DateOfDismissal = new DateTime(2014, 11, 11)
                }
            );
        }
    }
}
