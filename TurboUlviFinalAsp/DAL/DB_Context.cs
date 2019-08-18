using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurboUlviFinalAsp.Models;

namespace TurboUlviFinalAsp.DAL
{
    public class DB_Context : IdentityDbContext<ApplicationUser>
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {
        }

        public DbSet<CarBody> CarBodies { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<GearBox> GearBoxes { get; set; }
        public DbSet<GraduationYear> GraduationYears { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Motor> Motors { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);




            builder.Entity(typeof(Marca)).HasData(
               new Marca { Id = 1, Name = "Nissan" },
               new Marca { Id = 2, Name = "Hyundai" },
               new Marca { Id = 3, Name = "Vaz" },
               new Marca { Id = 4, Name = "Dodge" },
               new Marca { Id = 5, Name = "Audi" },
               new Marca { Id = 6, Name = "BMW" },
               new Marca { Id = 7, Name = "Opel" },
               new Marca { Id = 8, Name = "Mercedes" }



               );
            builder.Entity(typeof(Model)).HasData(
                new Model { Id = 1, Name = "GTR R-35", MarcaId = 1 },
                new Model { Id = 2, Name = "GTR R-34", MarcaId = 1 },
                new Model { Id = 3, Name = "Altima", MarcaId = 1 },
                new Model { Id = 4, Name = "Petrol", MarcaId = 1 },
                new Model { Id = 5, Name = "Elantra", MarcaId = 2 },
                new Model { Id = 6, Name = "Azera", MarcaId = 2 },
                new Model { Id = 7, Name = "Coupe", MarcaId = 2 },
                new Model { Id = 8, Name = "Sonata", MarcaId = 2 },
                new Model { Id = 9, Name = "Priora", MarcaId = 3 },
                new Model { Id = 10, Name = "Niva", MarcaId = 3 },
                new Model { Id = 11, Name = "2106", MarcaId = 3 },
                new Model { Id = 12, Name = "2107", MarcaId = 3 },
                new Model { Id = 13, Name = "2108", MarcaId = 3 },
                new Model { Id = 14, Name = "Challenger", MarcaId = 4 },
                new Model { Id = 15, Name = "Charger", MarcaId = 4 },
                new Model { Id = 16, Name = "Dart", MarcaId = 4 },
                new Model { Id = 17, Name = "Durango", MarcaId = 4 },
                new Model { Id = 18, Name = "Nitro", MarcaId = 4 },
                new Model { Id = 19, Name = "Stratus", MarcaId = 4 },
                new Model { Id = 20, Name = "A4", MarcaId = 5 },
                new Model { Id = 21, Name = "A4", MarcaId = 5 },
                new Model { Id = 22, Name = "A6", MarcaId = 5 },
                new Model { Id = 23, Name = "Q7", MarcaId = 5 },
                new Model { Id = 24, Name = "Q8", MarcaId = 5 },
                new Model { Id = 25, Name = "TTS", MarcaId = 5 },
                new Model { Id = 26, Name = "525", MarcaId = 6 },
                new Model { Id = 27, Name = "650", MarcaId = 6 },
                new Model { Id = 28, Name = "750", MarcaId = 6 },
                new Model { Id = 29, Name = "M3", MarcaId = 6 },
                new Model { Id = 30, Name = "M4", MarcaId = 6 },
                new Model { Id = 31, Name = "M5", MarcaId = 6 },
                new Model { Id = 32, Name = "X5", MarcaId = 6 },
                new Model { Id = 33, Name = "X6", MarcaId = 6 },
                new Model { Id = 34, Name = "Z4", MarcaId = 6 },
                new Model { Id = 35, Name = "Astra", MarcaId = 7 },
                new Model { Id = 36, Name = "Combo", MarcaId = 7 },
                new Model { Id = 37, Name = "Corsa", MarcaId = 7 },
                new Model { Id = 38, Name = "Omega", MarcaId = 7 },
                new Model { Id = 39, Name = "Vita", MarcaId = 7 },
                new Model { Id = 41, Name = "Zafira", MarcaId = 7 },
                new Model { Id = 42, Name = "190", MarcaId = 8 },
                new Model { Id = 43, Name = "200", MarcaId = 8 },
                new Model { Id = 44, Name = "A200", MarcaId = 8 },
                new Model { Id = 45, Name = "B200", MarcaId = 8 },
                new Model { Id = 46, Name = "C200", MarcaId = 8 },
                new Model { Id = 47, Name = "AMG GT", MarcaId = 8 },
                new Model { Id = 48, Name = "GLK-320", MarcaId = 8 },
                new Model { Id = 49, Name = "ML 500", MarcaId = 8 },
                new Model { Id = 50, Name = "S 500", MarcaId = 8 }


                );
            builder.Entity(typeof(CarBody)).HasData(
                new CarBody { Id = 1, Name = "Avtobus" },
                new CarBody { Id = 2, Name = "Furqon" },
                new CarBody { Id = 3, Name = "Hetcbek" },
                new CarBody { Id = 4, Name = "Kupe" },
                new CarBody { Id = 5, Name = "Motosiklet" },
                new CarBody { Id = 6, Name = "SUV" },
                new CarBody { Id = 7, Name = "Pikap" },
                new CarBody { Id = 8, Name = "Sedan" },
                new CarBody { Id = 9, Name = "Van" }
                );

            builder.Entity(typeof(Motor)).HasData(
              new Motor { Id = 1, Hecmi = 100 },
              new Motor { Id = 2, Hecmi = 200 },
              new Motor { Id = 3, Hecmi = 300 },
              new Motor { Id = 4, Hecmi = 400 },
              new Motor { Id = 5, Hecmi = 500 },
              new Motor { Id = 6, Hecmi = 600 },
              new Motor { Id = 7, Hecmi = 700 },
              new Motor { Id = 8, Hecmi = 800 },
              new Motor { Id = 9, Hecmi = 900 },
              new Motor { Id = 10, Hecmi = 1000 },
              new Motor { Id = 11, Hecmi = 1200 },
              new Motor { Id = 12, Hecmi = 1500 },
              new Motor { Id = 13, Hecmi = 2000 },
              new Motor { Id = 14, Hecmi = 3000 },
              new Motor { Id = 15, Hecmi = 5000 },
              new Motor { Id = 16, Hecmi = 6000 },
              new Motor { Id = 17, Hecmi = 9000 },
              new Motor { Id = 18, Hecmi = 10000 },
              new Motor { Id = 19, Hecmi = 15000 }


              );
            builder.Entity(typeof(Transmission)).HasData(
                new Transmission { Id = 1, Name = "Arxa" },
                new Transmission { Id = 2, Name = "On" },
                new Transmission { Id = 3, Name = "Tam" }
                );
            builder.Entity(typeof(Color)).HasData(
                new Color { Id = 1, Name = "Ag" },
                new Color { Id = 2, Name = "Qara" },
                new Color { Id = 3, Name = "Qehveyi" },
                new Color { Id = 4, Name = "Yasil" },
                new Color { Id = 5, Name = "Goy" },
                new Color { Id = 6, Name = "Qirmizi" },
                new Color { Id = 7, Name = "Cehrayi" },
                new Color { Id = 8, Name = "Boz" },
                new Color { Id = 9, Name = "Qizili" },
                new Color { Id = 10, Name = "Gumusu" },
                new Color { Id = 11, Name = "Sari" }

                );
            builder.Entity(typeof(City)).HasData(
                new City { Id = 1, Name = "Baki" },
                new City { Id = 2, Name = "Semkir" },
                new City { Id = 3, Name = "Gence" },
                new City { Id = 4, Name = "Qazax" },
                new City { Id = 5, Name = "Qax" },
                new City { Id = 6, Name = "Astara" }
                );


            builder.Entity(typeof(GearBox)).HasData(
                new GearBox { Id = 1, Name = "Avtomatik" },
                new GearBox { Id = 2, Name = "Mexaniki" },
                new GearBox { Id = 3, Name = "Yari-Avtomatik" }



                );
            builder.Entity(typeof(Fuel)).HasData(
                new Fuel { Id = 1, Name = "Benzin" },
                new Fuel { Id = 2, Name = "Dizel" },
                new Fuel { Id = 3, Name = "Qaz" },
                new Fuel { Id = 4, Name = "Hibrid" },
                new Fuel { Id = 5, Name = "Elektrik" }
                );

            builder.Entity(typeof(GraduationYear)).HasData(
                new GraduationYear { Id = 1, Year = 1910 },
                new GraduationYear { Id = 2, Year = 1911 },
                new GraduationYear { Id = 3, Year = 1912 },
                new GraduationYear { Id = 4, Year = 1913 },
                new GraduationYear { Id = 5, Year = 1914 },
                new GraduationYear { Id = 6, Year = 1915 },
                new GraduationYear { Id = 7, Year = 1916 },
                new GraduationYear { Id = 8, Year = 1917 },
                new GraduationYear { Id = 9, Year = 1918 },
                new GraduationYear { Id = 10, Year = 1919 },
                new GraduationYear { Id = 11, Year = 1921 },
                new GraduationYear { Id = 12, Year = 1922 },
                new GraduationYear { Id = 13, Year = 1923 },
                new GraduationYear { Id = 14, Year = 1924 },
                new GraduationYear { Id = 15, Year = 1925 },
                new GraduationYear { Id = 16, Year = 1926 },
                new GraduationYear { Id = 17, Year = 1927 },
                new GraduationYear { Id = 18, Year = 1928 },
                new GraduationYear { Id = 19, Year = 1929 },
                new GraduationYear { Id = 20, Year = 1930 },
                new GraduationYear { Id = 21, Year = 1931 },
                new GraduationYear { Id = 22, Year = 1932 },
                new GraduationYear { Id = 23, Year = 1933 },
                new GraduationYear { Id = 24, Year = 1934 },
                new GraduationYear { Id = 25, Year = 1935 },
                new GraduationYear { Id = 26, Year = 1936 },
                new GraduationYear { Id = 27, Year = 1937 },
                new GraduationYear { Id = 28, Year = 1938 },
                new GraduationYear { Id = 29, Year = 1939 },
                new GraduationYear { Id = 30, Year = 1940 },
                new GraduationYear { Id = 31, Year = 1941 },
                new GraduationYear { Id = 32, Year = 1942 },
                new GraduationYear { Id = 33, Year = 1943 },
                new GraduationYear { Id = 34, Year = 1944 },
                new GraduationYear { Id = 35, Year = 1945 },
                new GraduationYear { Id = 36, Year = 1946 },
                new GraduationYear { Id = 37, Year = 1947 },
                new GraduationYear { Id = 38, Year = 1948 },
                new GraduationYear { Id = 39, Year = 1949 },
                new GraduationYear { Id = 40, Year = 1950 },
                new GraduationYear { Id = 41, Year = 1951 },
                new GraduationYear { Id = 42, Year = 1952 },
                new GraduationYear { Id = 43, Year = 1953 },
                new GraduationYear { Id = 44, Year = 1954 },
                new GraduationYear { Id = 45, Year = 1955 },
                new GraduationYear { Id = 46, Year = 1956 },
                new GraduationYear { Id = 47, Year = 1957 },
                new GraduationYear { Id = 48, Year = 1958 },
                new GraduationYear { Id = 49, Year = 1959 },
                new GraduationYear { Id = 50, Year = 1960 },
                new GraduationYear { Id = 51, Year = 1961 },
                new GraduationYear { Id = 52, Year = 1962 },
                new GraduationYear { Id = 53, Year = 1963 },
                new GraduationYear { Id = 54, Year = 1964 },
                new GraduationYear { Id = 55, Year = 1965 },
                new GraduationYear { Id = 56, Year = 1966 },
                new GraduationYear { Id = 57, Year = 1967 },
                new GraduationYear { Id = 58, Year = 1968 },
                new GraduationYear { Id = 59, Year = 1969 },
                new GraduationYear { Id = 60, Year = 1970 },
                new GraduationYear { Id = 61, Year = 1971 },
                new GraduationYear { Id = 62, Year = 1972 },
                new GraduationYear { Id = 63, Year = 1973 },
                new GraduationYear { Id = 64, Year = 1974 },
                new GraduationYear { Id = 65, Year = 1975 },
                new GraduationYear { Id = 66, Year = 1976 },
                new GraduationYear { Id = 67, Year = 1977 },
                new GraduationYear { Id = 68, Year = 1978 },
                new GraduationYear { Id = 69, Year = 1979 },
                new GraduationYear { Id = 70, Year = 1980 },
                new GraduationYear { Id = 71, Year = 1981 },
                new GraduationYear { Id = 72, Year = 1982 },
                new GraduationYear { Id = 73, Year = 1983 },
                new GraduationYear { Id = 74, Year = 1984 },
                new GraduationYear { Id = 75, Year = 1985 },
                new GraduationYear { Id = 76, Year = 1986 },
                new GraduationYear { Id = 77, Year = 1987 },
                new GraduationYear { Id = 78, Year = 1988 },
                new GraduationYear { Id = 79, Year = 1989 },
                new GraduationYear { Id = 80, Year = 1990 },
                new GraduationYear { Id = 81, Year = 1991 },
                new GraduationYear { Id = 82, Year = 1992 },
                new GraduationYear { Id = 83, Year = 1993 },
                new GraduationYear { Id = 84, Year = 1994 },
                new GraduationYear { Id = 85, Year = 1995 },
                new GraduationYear { Id = 86, Year = 1996 },
                new GraduationYear { Id = 87, Year = 1997 },
                new GraduationYear { Id = 88, Year = 1998 },
                new GraduationYear { Id = 89, Year = 1999 },
                new GraduationYear { Id = 90, Year = 2000 },
                new GraduationYear { Id = 91, Year = 2001 },
                new GraduationYear { Id = 92, Year = 2002 },
                new GraduationYear { Id = 93, Year = 2003 },
                new GraduationYear { Id = 94, Year = 2004 },
                new GraduationYear { Id = 95, Year = 2005 },
                new GraduationYear { Id = 96, Year = 2006 },
                new GraduationYear { Id = 97, Year = 2007 },
                new GraduationYear { Id = 98, Year = 2008 },
                new GraduationYear { Id = 99, Year = 2009 },
                new GraduationYear { Id = 100, Year = 2010 }
                );
        }
    }
}
