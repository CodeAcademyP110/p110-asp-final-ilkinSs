using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TurboUlviFinalAsp.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 100, nullable: false),
                    Lastname = table.Column<string>(nullable: true),
                    RegistrationTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarBodies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBodies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GraduationYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraduationYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marcas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Hecmi = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
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
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
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
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    MarcaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Marcas_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Price = table.Column<decimal>(nullable: false),
                    Distance = table.Column<int>(nullable: false),
                    PhotoUrl = table.Column<string>(nullable: true),
                    ShortInfo = table.Column<string>(maxLength: 500, nullable: false),
                    FullInfo = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    CarBodyId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    ColorId = table.Column<int>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    GearBoxId = table.Column<int>(nullable: false),
                    GraduationYearId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    MotorId = table.Column<int>(nullable: false),
                    TransmissionId = table.Column<int>(nullable: false),
                    ApplicationUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_CarBodies_CarBodyId",
                        column: x => x.CarBodyId,
                        principalTable: "CarBodies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_GearBoxes_GearBoxId",
                        column: x => x.GearBoxId,
                        principalTable: "GearBoxes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_GraduationYears_GraduationYearId",
                        column: x => x.GraduationYearId,
                        principalTable: "GraduationYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Announcements_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarBodies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Avtobus" },
                    { 2, "Furqon" },
                    { 3, "Hetcbek" },
                    { 4, "Kupe" },
                    { 5, "Motosiklet" },
                    { 6, "SUV" },
                    { 7, "Pikap" },
                    { 8, "Sedan" },
                    { 9, "Van" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Astara" },
                    { 4, "Qazax" },
                    { 5, "Qax" },
                    { 2, "Semkir" },
                    { 1, "Baki" },
                    { 3, "Gence" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ag" },
                    { 2, "Qara" },
                    { 3, "Qehveyi" },
                    { 4, "Yasil" },
                    { 5, "Goy" },
                    { 6, "Qirmizi" },
                    { 7, "Cehrayi" },
                    { 8, "Boz" },
                    { 9, "Qizili" },
                    { 10, "Gumusu" },
                    { 11, "Sari" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Elektrik" },
                    { 4, "Hibrid" },
                    { 3, "Qaz" },
                    { 2, "Dizel" },
                    { 1, "Benzin" }
                });

            migrationBuilder.InsertData(
                table: "GearBoxes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Avtomatik" },
                    { 2, "Mexaniki" },
                    { 3, "Yari-Avtomatik" }
                });

            migrationBuilder.InsertData(
                table: "GraduationYears",
                columns: new[] { "Id", "Year" },
                values: new object[,]
                {
                    { 74, 1984 },
                    { 73, 1983 },
                    { 72, 1982 },
                    { 71, 1981 },
                    { 70, 1980 },
                    { 69, 1979 },
                    { 68, 1978 },
                    { 67, 1977 },
                    { 66, 1976 },
                    { 65, 1975 },
                    { 64, 1974 },
                    { 62, 1972 },
                    { 75, 1985 },
                    { 61, 1971 },
                    { 60, 1970 },
                    { 59, 1969 },
                    { 58, 1968 },
                    { 57, 1967 },
                    { 56, 1966 },
                    { 55, 1965 },
                    { 54, 1964 },
                    { 53, 1963 },
                    { 63, 1973 },
                    { 76, 1986 },
                    { 93, 2003 },
                    { 78, 1988 },
                    { 100, 2010 },
                    { 99, 2009 },
                    { 98, 2008 },
                    { 97, 2007 },
                    { 96, 2006 },
                    { 95, 2005 },
                    { 94, 2004 },
                    { 52, 1962 },
                    { 92, 2002 },
                    { 91, 2001 },
                    { 77, 1987 },
                    { 90, 2000 },
                    { 88, 1998 },
                    { 87, 1997 },
                    { 86, 1996 },
                    { 85, 1995 },
                    { 84, 1994 },
                    { 83, 1993 },
                    { 82, 1992 },
                    { 81, 1991 },
                    { 80, 1990 },
                    { 79, 1989 },
                    { 89, 1999 },
                    { 51, 1961 },
                    { 48, 1958 },
                    { 49, 1959 },
                    { 22, 1932 },
                    { 21, 1931 },
                    { 20, 1930 },
                    { 19, 1929 },
                    { 18, 1928 },
                    { 17, 1927 },
                    { 16, 1926 },
                    { 15, 1925 },
                    { 14, 1924 },
                    { 13, 1923 },
                    { 23, 1933 },
                    { 12, 1922 },
                    { 50, 1960 },
                    { 9, 1918 },
                    { 8, 1917 },
                    { 7, 1916 },
                    { 6, 1915 },
                    { 5, 1914 },
                    { 4, 1913 },
                    { 3, 1912 },
                    { 2, 1911 },
                    { 1, 1910 },
                    { 11, 1921 },
                    { 24, 1934 },
                    { 10, 1919 },
                    { 26, 1936 },
                    { 47, 1957 },
                    { 46, 1956 },
                    { 45, 1955 },
                    { 44, 1954 },
                    { 43, 1953 },
                    { 42, 1952 },
                    { 41, 1951 },
                    { 40, 1950 },
                    { 38, 1948 },
                    { 37, 1947 },
                    { 39, 1949 },
                    { 35, 1945 },
                    { 34, 1944 },
                    { 33, 1943 },
                    { 32, 1942 },
                    { 31, 1941 },
                    { 30, 1940 },
                    { 29, 1939 },
                    { 28, 1938 },
                    { 27, 1937 },
                    { 36, 1946 },
                    { 25, 1935 }
                });

            migrationBuilder.InsertData(
                table: "Marcas",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Audi" },
                    { 8, "Mercedes" },
                    { 7, "Opel" },
                    { 6, "BMW" },
                    { 4, "Dodge" },
                    { 2, "Hyundai" },
                    { 1, "Nissan" },
                    { 3, "Vaz" }
                });

            migrationBuilder.InsertData(
                table: "Motors",
                columns: new[] { "Id", "Hecmi" },
                values: new object[,]
                {
                    { 19, 15000 },
                    { 18, 10000 },
                    { 17, 9000 },
                    { 16, 6000 },
                    { 15, 5000 },
                    { 14, 3000 },
                    { 13, 2000 },
                    { 12, 1500 },
                    { 11, 1200 },
                    { 10, 1000 },
                    { 8, 800 },
                    { 7, 700 },
                    { 6, 600 },
                    { 5, 500 },
                    { 4, 400 },
                    { 3, 300 },
                    { 2, 200 },
                    { 1, 100 },
                    { 9, 900 }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "On" },
                    { 1, "Arxa" },
                    { 3, "Tam" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "MarcaId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "GTR R-35" },
                    { 27, 6, "650" },
                    { 28, 6, "750" },
                    { 29, 6, "M3" },
                    { 30, 6, "M4" },
                    { 31, 6, "M5" },
                    { 32, 6, "X5" },
                    { 33, 6, "X6" },
                    { 34, 6, "Z4" },
                    { 35, 7, "Astra" },
                    { 36, 7, "Combo" },
                    { 37, 7, "Corsa" },
                    { 38, 7, "Omega" },
                    { 39, 7, "Vita" },
                    { 41, 7, "Zafira" },
                    { 42, 8, "190" },
                    { 43, 8, "200" },
                    { 44, 8, "A200" },
                    { 45, 8, "B200" },
                    { 46, 8, "C200" },
                    { 47, 8, "AMG GT" },
                    { 48, 8, "GLK-320" },
                    { 26, 6, "525" },
                    { 49, 8, "ML 500" },
                    { 25, 5, "TTS" },
                    { 23, 5, "Q7" },
                    { 2, 1, "GTR R-34" },
                    { 3, 1, "Altima" },
                    { 4, 1, "Petrol" },
                    { 5, 2, "Elantra" },
                    { 6, 2, "Azera" },
                    { 7, 2, "Coupe" },
                    { 8, 2, "Sonata" },
                    { 9, 3, "Priora" },
                    { 10, 3, "Niva" },
                    { 11, 3, "2106" },
                    { 12, 3, "2107" },
                    { 13, 3, "2108" },
                    { 14, 4, "Challenger" },
                    { 15, 4, "Charger" },
                    { 16, 4, "Dart" },
                    { 17, 4, "Durango" },
                    { 18, 4, "Nitro" },
                    { 19, 4, "Stratus" },
                    { 20, 5, "A4" },
                    { 21, 5, "A4" },
                    { 22, 5, "A6" },
                    { 24, 5, "Q8" },
                    { 50, 8, "S 500" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ApplicationUserId",
                table: "Announcements",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CarBodyId",
                table: "Announcements",
                column: "CarBodyId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CityId",
                table: "Announcements",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ColorId",
                table: "Announcements",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_FuelId",
                table: "Announcements",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_GearBoxId",
                table: "Announcements",
                column: "GearBoxId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_GraduationYearId",
                table: "Announcements",
                column: "GraduationYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_ModelId",
                table: "Announcements",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_MotorId",
                table: "Announcements",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_TransmissionId",
                table: "Announcements",
                column: "TransmissionId");

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
                name: "IX_Models_MarcaId",
                table: "Models",
                column: "MarcaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Announcements");

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
                name: "CarBodies");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "GearBoxes");

            migrationBuilder.DropTable(
                name: "GraduationYears");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Motors");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Marcas");
        }
    }
}
