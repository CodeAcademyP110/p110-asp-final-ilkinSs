﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TurboUlviFinalAsp.DAL;

namespace TurboUlviFinalAsp.Migrations
{
    [DbContext(typeof(DB_Context))]
    [Migration("20190814153657_lb12")]
    partial class lb12
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Announcement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<int>("CarBodyId");

                    b.Property<int>("CityId");

                    b.Property<int>("ColorId");

                    b.Property<int>("Distance");

                    b.Property<int>("FuelId");

                    b.Property<string>("FullInfo");

                    b.Property<int>("GearBoxId");

                    b.Property<int>("GraduationYearId");

                    b.Property<bool>("IsVip");

                    b.Property<int>("ModelId");

                    b.Property<int>("MotorId");

                    b.Property<string>("PhotoUrl");

                    b.Property<decimal>("Price");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("ShortInfo")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("TransmissionId");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CarBodyId");

                    b.HasIndex("CityId");

                    b.HasIndex("ColorId");

                    b.HasIndex("FuelId");

                    b.HasIndex("GearBoxId");

                    b.HasIndex("GraduationYearId");

                    b.HasIndex("ModelId");

                    b.HasIndex("MotorId");

                    b.HasIndex("TransmissionId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Lastname");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<DateTime>("RegistrationTime");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.CarBody", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("CarBodies");

                    b.HasData(
                        new { Id = 1, Name = "Avtobus" },
                        new { Id = 2, Name = "Furqon" },
                        new { Id = 3, Name = "Hetcbek" },
                        new { Id = 4, Name = "Kupe" },
                        new { Id = 5, Name = "Motosiklet" },
                        new { Id = 6, Name = "SUV" },
                        new { Id = 7, Name = "Pikap" },
                        new { Id = 8, Name = "Sedan" },
                        new { Id = 9, Name = "Van" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new { Id = 1, Name = "Baki" },
                        new { Id = 2, Name = "Semkir" },
                        new { Id = 3, Name = "Gence" },
                        new { Id = 4, Name = "Qazax" },
                        new { Id = 5, Name = "Qax" },
                        new { Id = 6, Name = "Astara" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new { Id = 1, Name = "Ag" },
                        new { Id = 2, Name = "Qara" },
                        new { Id = 3, Name = "Qehveyi" },
                        new { Id = 4, Name = "Yasil" },
                        new { Id = 5, Name = "Goy" },
                        new { Id = 6, Name = "Qirmizi" },
                        new { Id = 7, Name = "Cehrayi" },
                        new { Id = 8, Name = "Boz" },
                        new { Id = 9, Name = "Qizili" },
                        new { Id = 10, Name = "Gumusu" },
                        new { Id = 11, Name = "Sari" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Fuel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Fuels");

                    b.HasData(
                        new { Id = 1, Name = "Benzin" },
                        new { Id = 2, Name = "Dizel" },
                        new { Id = 3, Name = "Qaz" },
                        new { Id = 4, Name = "Hibrid" },
                        new { Id = 5, Name = "Elektrik" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.GearBox", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("GearBoxes");

                    b.HasData(
                        new { Id = 1, Name = "Avtomatik" },
                        new { Id = 2, Name = "Mexaniki" },
                        new { Id = 3, Name = "Yari-Avtomatik" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.GraduationYear", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.ToTable("GraduationYears");

                    b.HasData(
                        new { Id = 1, Year = 1910 },
                        new { Id = 2, Year = 1911 },
                        new { Id = 3, Year = 1912 },
                        new { Id = 4, Year = 1913 },
                        new { Id = 5, Year = 1914 },
                        new { Id = 6, Year = 1915 },
                        new { Id = 7, Year = 1916 },
                        new { Id = 8, Year = 1917 },
                        new { Id = 9, Year = 1918 },
                        new { Id = 10, Year = 1919 },
                        new { Id = 11, Year = 1921 },
                        new { Id = 12, Year = 1922 },
                        new { Id = 13, Year = 1923 },
                        new { Id = 14, Year = 1924 },
                        new { Id = 15, Year = 1925 },
                        new { Id = 16, Year = 1926 },
                        new { Id = 17, Year = 1927 },
                        new { Id = 18, Year = 1928 },
                        new { Id = 19, Year = 1929 },
                        new { Id = 20, Year = 1930 },
                        new { Id = 21, Year = 1931 },
                        new { Id = 22, Year = 1932 },
                        new { Id = 23, Year = 1933 },
                        new { Id = 24, Year = 1934 },
                        new { Id = 25, Year = 1935 },
                        new { Id = 26, Year = 1936 },
                        new { Id = 27, Year = 1937 },
                        new { Id = 28, Year = 1938 },
                        new { Id = 29, Year = 1939 },
                        new { Id = 30, Year = 1940 },
                        new { Id = 31, Year = 1941 },
                        new { Id = 32, Year = 1942 },
                        new { Id = 33, Year = 1943 },
                        new { Id = 34, Year = 1944 },
                        new { Id = 35, Year = 1945 },
                        new { Id = 36, Year = 1946 },
                        new { Id = 37, Year = 1947 },
                        new { Id = 38, Year = 1948 },
                        new { Id = 39, Year = 1949 },
                        new { Id = 40, Year = 1950 },
                        new { Id = 41, Year = 1951 },
                        new { Id = 42, Year = 1952 },
                        new { Id = 43, Year = 1953 },
                        new { Id = 44, Year = 1954 },
                        new { Id = 45, Year = 1955 },
                        new { Id = 46, Year = 1956 },
                        new { Id = 47, Year = 1957 },
                        new { Id = 48, Year = 1958 },
                        new { Id = 49, Year = 1959 },
                        new { Id = 50, Year = 1960 },
                        new { Id = 51, Year = 1961 },
                        new { Id = 52, Year = 1962 },
                        new { Id = 53, Year = 1963 },
                        new { Id = 54, Year = 1964 },
                        new { Id = 55, Year = 1965 },
                        new { Id = 56, Year = 1966 },
                        new { Id = 57, Year = 1967 },
                        new { Id = 58, Year = 1968 },
                        new { Id = 59, Year = 1969 },
                        new { Id = 60, Year = 1970 },
                        new { Id = 61, Year = 1971 },
                        new { Id = 62, Year = 1972 },
                        new { Id = 63, Year = 1973 },
                        new { Id = 64, Year = 1974 },
                        new { Id = 65, Year = 1975 },
                        new { Id = 66, Year = 1976 },
                        new { Id = 67, Year = 1977 },
                        new { Id = 68, Year = 1978 },
                        new { Id = 69, Year = 1979 },
                        new { Id = 70, Year = 1980 },
                        new { Id = 71, Year = 1981 },
                        new { Id = 72, Year = 1982 },
                        new { Id = 73, Year = 1983 },
                        new { Id = 74, Year = 1984 },
                        new { Id = 75, Year = 1985 },
                        new { Id = 76, Year = 1986 },
                        new { Id = 77, Year = 1987 },
                        new { Id = 78, Year = 1988 },
                        new { Id = 79, Year = 1989 },
                        new { Id = 80, Year = 1990 },
                        new { Id = 81, Year = 1991 },
                        new { Id = 82, Year = 1992 },
                        new { Id = 83, Year = 1993 },
                        new { Id = 84, Year = 1994 },
                        new { Id = 85, Year = 1995 },
                        new { Id = 86, Year = 1996 },
                        new { Id = 87, Year = 1997 },
                        new { Id = 88, Year = 1998 },
                        new { Id = 89, Year = 1999 },
                        new { Id = 90, Year = 2000 },
                        new { Id = 91, Year = 2001 },
                        new { Id = 92, Year = 2002 },
                        new { Id = 93, Year = 2003 },
                        new { Id = 94, Year = 2004 },
                        new { Id = 95, Year = 2005 },
                        new { Id = 96, Year = 2006 },
                        new { Id = 97, Year = 2007 },
                        new { Id = 98, Year = 2008 },
                        new { Id = 99, Year = 2009 },
                        new { Id = 100, Year = 2010 }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnnouncementId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("Image");
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Marcas");

                    b.HasData(
                        new { Id = 1, Name = "Nissan" },
                        new { Id = 2, Name = "Hyundai" },
                        new { Id = 3, Name = "Vaz" },
                        new { Id = 4, Name = "Dodge" },
                        new { Id = 5, Name = "Audi" },
                        new { Id = 6, Name = "BMW" },
                        new { Id = 7, Name = "Opel" },
                        new { Id = 8, Name = "Mercedes" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Model", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MarcaId");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Models");

                    b.HasData(
                        new { Id = 1, MarcaId = 1, Name = "GTR R-35" },
                        new { Id = 2, MarcaId = 1, Name = "GTR R-34" },
                        new { Id = 3, MarcaId = 1, Name = "Altima" },
                        new { Id = 4, MarcaId = 1, Name = "Petrol" },
                        new { Id = 5, MarcaId = 2, Name = "Elantra" },
                        new { Id = 6, MarcaId = 2, Name = "Azera" },
                        new { Id = 7, MarcaId = 2, Name = "Coupe" },
                        new { Id = 8, MarcaId = 2, Name = "Sonata" },
                        new { Id = 9, MarcaId = 3, Name = "Priora" },
                        new { Id = 10, MarcaId = 3, Name = "Niva" },
                        new { Id = 11, MarcaId = 3, Name = "2106" },
                        new { Id = 12, MarcaId = 3, Name = "2107" },
                        new { Id = 13, MarcaId = 3, Name = "2108" },
                        new { Id = 14, MarcaId = 4, Name = "Challenger" },
                        new { Id = 15, MarcaId = 4, Name = "Charger" },
                        new { Id = 16, MarcaId = 4, Name = "Dart" },
                        new { Id = 17, MarcaId = 4, Name = "Durango" },
                        new { Id = 18, MarcaId = 4, Name = "Nitro" },
                        new { Id = 19, MarcaId = 4, Name = "Stratus" },
                        new { Id = 20, MarcaId = 5, Name = "A4" },
                        new { Id = 21, MarcaId = 5, Name = "A4" },
                        new { Id = 22, MarcaId = 5, Name = "A6" },
                        new { Id = 23, MarcaId = 5, Name = "Q7" },
                        new { Id = 24, MarcaId = 5, Name = "Q8" },
                        new { Id = 25, MarcaId = 5, Name = "TTS" },
                        new { Id = 26, MarcaId = 6, Name = "525" },
                        new { Id = 27, MarcaId = 6, Name = "650" },
                        new { Id = 28, MarcaId = 6, Name = "750" },
                        new { Id = 29, MarcaId = 6, Name = "M3" },
                        new { Id = 30, MarcaId = 6, Name = "M4" },
                        new { Id = 31, MarcaId = 6, Name = "M5" },
                        new { Id = 32, MarcaId = 6, Name = "X5" },
                        new { Id = 33, MarcaId = 6, Name = "X6" },
                        new { Id = 34, MarcaId = 6, Name = "Z4" },
                        new { Id = 35, MarcaId = 7, Name = "Astra" },
                        new { Id = 36, MarcaId = 7, Name = "Combo" },
                        new { Id = 37, MarcaId = 7, Name = "Corsa" },
                        new { Id = 38, MarcaId = 7, Name = "Omega" },
                        new { Id = 39, MarcaId = 7, Name = "Vita" },
                        new { Id = 41, MarcaId = 7, Name = "Zafira" },
                        new { Id = 42, MarcaId = 8, Name = "190" },
                        new { Id = 43, MarcaId = 8, Name = "200" },
                        new { Id = 44, MarcaId = 8, Name = "A200" },
                        new { Id = 45, MarcaId = 8, Name = "B200" },
                        new { Id = 46, MarcaId = 8, Name = "C200" },
                        new { Id = 47, MarcaId = 8, Name = "AMG GT" },
                        new { Id = 48, MarcaId = 8, Name = "GLK-320" },
                        new { Id = 49, MarcaId = 8, Name = "ML 500" },
                        new { Id = 50, MarcaId = 8, Name = "S 500" }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Motor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Hecmi");

                    b.HasKey("Id");

                    b.ToTable("Motors");

                    b.HasData(
                        new { Id = 1, Hecmi = 100 },
                        new { Id = 2, Hecmi = 200 },
                        new { Id = 3, Hecmi = 300 },
                        new { Id = 4, Hecmi = 400 },
                        new { Id = 5, Hecmi = 500 },
                        new { Id = 6, Hecmi = 600 },
                        new { Id = 7, Hecmi = 700 },
                        new { Id = 8, Hecmi = 800 },
                        new { Id = 9, Hecmi = 900 },
                        new { Id = 10, Hecmi = 1000 },
                        new { Id = 11, Hecmi = 1200 },
                        new { Id = 12, Hecmi = 1500 },
                        new { Id = 13, Hecmi = 2000 },
                        new { Id = 14, Hecmi = 3000 },
                        new { Id = 15, Hecmi = 5000 },
                        new { Id = 16, Hecmi = 6000 },
                        new { Id = 17, Hecmi = 9000 },
                        new { Id = 18, Hecmi = 10000 },
                        new { Id = 19, Hecmi = 15000 }
                    );
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Transmission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Transmissions");

                    b.HasData(
                        new { Id = 1, Name = "Arxa" },
                        new { Id = 2, Name = "On" },
                        new { Id = 3, Name = "Tam" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Announcement", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.ApplicationUser", "ApplicationUser")
                        .WithMany("Announcements")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("TurboUlviFinalAsp.Models.CarBody", "CarBody")
                        .WithMany()
                        .HasForeignKey("CarBodyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.Fuel", "Fuel")
                        .WithMany()
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.GearBox", "GearBox")
                        .WithMany()
                        .HasForeignKey("GearBoxId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.GraduationYear", "GraduationYear")
                        .WithMany()
                        .HasForeignKey("GraduationYearId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.Model", "Model")
                        .WithMany()
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.Motor", "Motor")
                        .WithMany()
                        .HasForeignKey("MotorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("TurboUlviFinalAsp.Models.Transmission", "Transmission")
                        .WithMany()
                        .HasForeignKey("TransmissionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Image", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.Announcement", "Announcement")
                        .WithMany("Images")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TurboUlviFinalAsp.Models.Model", b =>
                {
                    b.HasOne("TurboUlviFinalAsp.Models.Marca", "marca")
                        .WithMany("Models")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
