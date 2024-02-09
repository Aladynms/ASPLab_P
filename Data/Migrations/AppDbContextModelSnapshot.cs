﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("Data.Entities.BranchEntity", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BranchId");

                    b.ToTable("branches");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            Title = "Firma XYZ"
                        },
                        new
                        {
                            BranchId = 2,
                            Title = "ABC Sp. z o.o."
                        },
                        new
                        {
                            BranchId = 3,
                            Title = "Inicjatywa Polska"
                        },
                        new
                        {
                            BranchId = 4,
                            Title = "Tech Innovators"
                        },
                        new
                        {
                            BranchId = 5,
                            Title = "Nowoczesne Rozwiązania"
                        });
                });

            modelBuilder.Entity("Data.Entities.EmployeeEntity", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BranchId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateOfDismissal")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateOfEmployment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("PESEL")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Position")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.HasIndex("BranchId");

                    b.ToTable("employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            BranchId = 1,
                            DateOfEmployment = new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "jan.kowalski@firmaxyz.com",
                            LastName = "Kowalski",
                            Name = "Jan",
                            PESEL = "80010112345",
                            Phone = "123456789",
                            Position = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            BranchId = 1,
                            DateOfDismissal = new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2015, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anna.nowak@firmaxyz.com",
                            LastName = "Nowak",
                            Name = "Anna",
                            PESEL = "90020223456",
                            Phone = "987654321",
                            Position = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            BranchId = 2,
                            DateOfEmployment = new DateTime(2012, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michal.wisniewski@abc.com",
                            LastName = "Wiśniewski",
                            Name = "Michał",
                            PESEL = "82030334567",
                            Phone = "234567891",
                            Position = 1
                        },
                        new
                        {
                            EmployeeId = 4,
                            BranchId = 2,
                            DateOfDismissal = new DateTime(2024, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "katarzyna.lewandowska@abc.com",
                            LastName = "Lewandowska",
                            Name = "Katarzyna",
                            PESEL = "85040445678",
                            Phone = "198765432",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 5,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2013, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "piotr.duda@inicjatywa.pl",
                            LastName = "Duda",
                            Name = "Piotr",
                            PESEL = "83050556789",
                            Phone = "543216789",
                            Position = 1
                        },
                        new
                        {
                            EmployeeId = 6,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "alicja.jankowska@inicjatywa.pl",
                            LastName = "Jankowska",
                            Name = "Alicja",
                            PESEL = "84060667890",
                            Phone = "876543210",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 7,
                            BranchId = 4,
                            DateOfEmployment = new DateTime(2011, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lukasz.kaminski@techinnovators.com",
                            LastName = "Kamiński",
                            Name = "Łukasz",
                            PESEL = "81070778901",
                            Phone = "654321098",
                            Position = 1
                        },
                        new
                        {
                            EmployeeId = 8,
                            BranchId = 4,
                            DateOfDismissal = new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2017, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "magdalena.zajac@techinnovators.com",
                            LastName = "Zając",
                            Name = "Magdalena",
                            PESEL = "83080889012",
                            Phone = "321098765",
                            Position = 5
                        },
                        new
                        {
                            EmployeeId = 9,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2014, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "tomasz.piotrowski@nowoczesne.pl",
                            LastName = "Piotrowski",
                            Name = "Tomasz",
                            PESEL = "84090990123",
                            Phone = "432109876",
                            Position = 1
                        },
                        new
                        {
                            EmployeeId = 10,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "monika.adamczyk@nowoczesne.pl",
                            LastName = "Adamczyk",
                            Name = "Monika",
                            PESEL = "87010101234",
                            Phone = "210987654",
                            Position = 6
                        },
                        new
                        {
                            EmployeeId = 11,
                            BranchId = 1,
                            DateOfEmployment = new DateTime(2016, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "karolina.wojcik@firmaxyz.com",
                            LastName = "Wójcik",
                            Name = "Karolina",
                            PESEL = "88020212345",
                            Phone = "345678912",
                            Position = 2
                        },
                        new
                        {
                            EmployeeId = 12,
                            BranchId = 1,
                            DateOfDismissal = new DateTime(2022, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfEmployment = new DateTime(2017, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "artur.kaczmarek@firmaxyz.com",
                            LastName = "Kaczmarek",
                            Name = "Artur",
                            PESEL = "90030323456",
                            Phone = "456789123",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 13,
                            BranchId = 2,
                            DateOfEmployment = new DateTime(2015, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "karol.zielinski@abc.com",
                            LastName = "Zieliński",
                            Name = "Karol",
                            PESEL = "89040434567",
                            Phone = "567891234",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 14,
                            BranchId = 2,
                            DateOfEmployment = new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "natalia.walczak@abc.com",
                            LastName = "Walczak",
                            Name = "Natalia",
                            PESEL = "91050545678",
                            Phone = "678912345",
                            Position = 5
                        },
                        new
                        {
                            EmployeeId = 15,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2016, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marcin.szymanski@inicjatywa.pl",
                            LastName = "Szymański",
                            Name = "Marcin",
                            PESEL = "92060656789",
                            Phone = "789123456",
                            Position = 2
                        },
                        new
                        {
                            EmployeeId = 16,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2020, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "patrycja.debska@inicjatywa.pl",
                            LastName = "Dębska",
                            Name = "Patrycja",
                            PESEL = "93070767890",
                            Phone = "891234567",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 17,
                            BranchId = 4,
                            DateOfEmployment = new DateTime(2018, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "damian.pawlak@techinnovators.com",
                            LastName = "Pawlak",
                            Name = "Damian",
                            PESEL = "94080878901",
                            Phone = "912345678",
                            Position = 2
                        },
                        new
                        {
                            EmployeeId = 18,
                            BranchId = 4,
                            DateOfEmployment = new DateTime(2021, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aleksandra.mazur@techinnovators.com",
                            LastName = "Mazur",
                            Name = "Aleksandra",
                            PESEL = "95090989012",
                            Phone = "123456789",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 19,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2018, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "rafal.witkowski@nowoczesne.pl",
                            LastName = "Witkowski",
                            Name = "Rafał",
                            PESEL = "96101090123",
                            Phone = "234567891",
                            Position = 2
                        },
                        new
                        {
                            EmployeeId = 20,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2022, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "wiktoria.baran@nowoczesne.pl",
                            LastName = "Baran",
                            Name = "Wiktoria",
                            PESEL = "97111101234",
                            Phone = "345678912",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 21,
                            BranchId = 1,
                            DateOfEmployment = new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "marta.lis@firmaxyz.com",
                            LastName = "Lis",
                            Name = "Marta",
                            PESEL = "98121212345",
                            Phone = "456789123",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 22,
                            BranchId = 1,
                            DateOfEmployment = new DateTime(2020, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "pawel.olszewski@firmaxyz.com",
                            LastName = "Olszewski",
                            Name = "Paweł",
                            PESEL = "99010123456",
                            Phone = "567891234",
                            Position = 5
                        },
                        new
                        {
                            EmployeeId = 23,
                            BranchId = 2,
                            DateOfEmployment = new DateTime(2018, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "joanna.krawczyk@abc.com",
                            LastName = "Krawczyk",
                            Name = "Joanna",
                            PESEL = "00020234567",
                            Phone = "678912345",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 24,
                            BranchId = 2,
                            DateOfEmployment = new DateTime(2021, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kamil.piotrowicz@abc.com",
                            LastName = "Piotrowicz",
                            Name = "Kamil",
                            PESEL = "01030345678",
                            Phone = "789123456",
                            Position = 6
                        },
                        new
                        {
                            EmployeeId = 25,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2017, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "agnieszka.jastrzebska@inicjatywa.pl",
                            LastName = "Jastrzębska",
                            Name = "Agnieszka",
                            PESEL = "02040456789",
                            Phone = "891234567",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 26,
                            BranchId = 3,
                            DateOfEmployment = new DateTime(2020, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "dawid.grabowski@inicjatywa.pl",
                            LastName = "Grabowski",
                            Name = "Dawid",
                            PESEL = "03050567890",
                            Phone = "912345678",
                            Position = 5
                        },
                        new
                        {
                            EmployeeId = 27,
                            BranchId = 4,
                            DateOfEmployment = new DateTime(2019, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "klaudia.wojciechowska@techinnovators.com",
                            LastName = "Wojciechowska",
                            Name = "Klaudia",
                            PESEL = "04060678901",
                            Phone = "123456789",
                            Position = 4
                        },
                        new
                        {
                            EmployeeId = 28,
                            BranchId = 4,
                            DateOfEmployment = new DateTime(2022, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "szymon.nowicki@techinnovators.com",
                            LastName = "Nowicki",
                            Name = "Szymon",
                            PESEL = "05070789012",
                            Phone = "234567891",
                            Position = 6
                        },
                        new
                        {
                            EmployeeId = 29,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2019, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "aleksander.kaczmarczyk@nowoczesne.pl",
                            LastName = "Kaczmarczyk",
                            Name = "Aleksander",
                            PESEL = "06080890123",
                            Phone = "345678912",
                            Position = 3
                        },
                        new
                        {
                            EmployeeId = 30,
                            BranchId = 5,
                            DateOfEmployment = new DateTime(2022, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "kinga.grabowska@nowoczesne.pl",
                            LastName = "Grabowska",
                            Name = "Kinga",
                            PESEL = "07090901234",
                            Phone = "456789123",
                            Position = 5
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "495544e7-7caa-469a-ab35-cfd14a35c146",
                            ConcurrencyStamp = "495544e7-7caa-469a-ab35-cfd14a35c146",
                            Name = "admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d9b0335e-7381-43ca-bcca-f86fd5c45bf2",
                            ConcurrencyStamp = "d9b0335e-7381-43ca-bcca-f86fd5c45bf2",
                            Name = "user",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "a25325e2-29bf-400d-86df-cf8e00c37ab0",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cf61ecf5-d63f-4f2e-b1cf-253c0c9b2a6a",
                            Email = "admin@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@WSEI.EDU.PL",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKf83Uz7HZB2qr/JSnmiqxKYRZLsfb8EoOSB8ToqUf4T7ZuQKdB+cz8110w7MEIH0g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "62811a37-4765-4036-aa23-5428d919d5b2",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        },
                        new
                        {
                            Id = "ad613de7-3b6c-439a-b023-5c1e4f777d34",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5f3ffa00-6947-4d9e-a311-5775191f6bc2",
                            Email = "user@wsei.edu.pl",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@WSEI.EDU.PL",
                            NormalizedUserName = "USER",
                            PasswordHash = "AQAAAAEAACcQAAAAEB7k2Zz3CXOOVaa2zZu2EbLq06ylC55iOHXMbUj1itWQ6v/6prvEGsUyjs1ycYIpFg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c53ca4a4-b744-4133-9945-ecf831d7aa5c",
                            TwoFactorEnabled = false,
                            UserName = "user"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "a25325e2-29bf-400d-86df-cf8e00c37ab0",
                            RoleId = "495544e7-7caa-469a-ab35-cfd14a35c146"
                        },
                        new
                        {
                            UserId = "ad613de7-3b6c-439a-b023-5c1e4f777d34",
                            RoleId = "d9b0335e-7381-43ca-bcca-f86fd5c45bf2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Data.Entities.BranchEntity", b =>
                {
                    b.OwnsOne("Data.Entities.Address", "Address", b1 =>
                        {
                            b1.Property<int>("BranchEntityBranchId")
                                .HasColumnType("INTEGER");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Number")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Region")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.Property<string>("Street")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("BranchEntityBranchId");

                            b1.ToTable("branches");

                            b1.WithOwner()
                                .HasForeignKey("BranchEntityBranchId");

                            b1.HasData(
                                new
                                {
                                    BranchEntityBranchId = 1,
                                    City = "Warszawa",
                                    Country = "Polska",
                                    Number = "123",
                                    PostalCode = "00-015",
                                    Region = "mazowieckie",
                                    Street = "Marszałkowska"
                                },
                                new
                                {
                                    BranchEntityBranchId = 2,
                                    City = "Kraków",
                                    Country = "Polska",
                                    Number = "7",
                                    PostalCode = "31-001",
                                    Region = "małopolskie",
                                    Street = "Wawel"
                                },
                                new
                                {
                                    BranchEntityBranchId = 3,
                                    City = "Gdańsk",
                                    Country = "Polska",
                                    Number = "22",
                                    PostalCode = "80-827",
                                    Region = "pomorskie",
                                    Street = "Długa"
                                },
                                new
                                {
                                    BranchEntityBranchId = 4,
                                    City = "Wrocław",
                                    Country = "Polska",
                                    Number = "15",
                                    PostalCode = "50-101",
                                    Region = "dolnośląskie",
                                    Street = "Rynek"
                                },
                                new
                                {
                                    BranchEntityBranchId = 5,
                                    City = "Poznań",
                                    Country = "Polska",
                                    Number = "80",
                                    PostalCode = "61-809",
                                    Region = "wielkopolskie",
                                    Street = "Święty Marcin"
                                });
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Data.Entities.EmployeeEntity", b =>
                {
                    b.HasOne("Data.Entities.BranchEntity", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.Entities.BranchEntity", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
