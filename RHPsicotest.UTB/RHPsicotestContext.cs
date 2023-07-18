using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Data;
using RHPsicotest.WebSite.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHPsicotest.UTB
{
    public class RHPsicotestContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Expedient> Expedients { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Factor> Factors { get; set; }

        public DbSet<Result> Results { get; set; }
        public DbSet<Role_User> Role_Users { get; set; }
        public DbSet<Test_Position> Test_Positions { get; set; }
        public DbSet<Test_Candidate> Test_Candidates { get; set; }
        public DbSet<Permission_Role> Permission_Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conection Somee
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=RHPsicotestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Permission_Role>()
                        .HasKey(pr => new { pr.IdPermission, pr.IdRole });

            modelBuilder.Entity<Role_User>()
                        .HasKey(ru => new { ru.IdRole, ru.IdUser });

            modelBuilder.Entity<Test_Position>()
                        .HasKey(tp => new { tp.IdTest, tp.IdPosition });

            modelBuilder.Entity<Result>()
                        .HasKey(r => new { r.IdExpedient, r.IdTest, r.IdFactor });

            modelBuilder.Entity<Test_Candidate>()
                        .HasKey(r => new { r.IdCandidate, r.IdTest });


            // Tabla de Permisos
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 1,
                PermissionName = "Lista-Usuarios",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 2,
                PermissionName = "Crear-Usuario",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 3,
                PermissionName = "Editar-Usuario",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 4,
                PermissionName = "Eliminar-Usuario",
            });

            // Tabla de Roles
            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 1,
                RoleName = "Super-Admin",
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 2,
                RoleName = "Administrador",
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 3,
                RoleName = "Candidato",
            });

            // Tabla de Pruebas
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 1,
                NameTest = "PPG-IPG",
                Time = "45 min.",
                Link = "Test_PPGIPG"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 2,
                NameTest = "OTIS",
                Time = "45 min.",
                Link = "Test_OTIS"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 3,
                NameTest = "Dominos",
                Time = "45 min.",
                Link = "Test_Dominos"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 4,
                NameTest = "BFQ",
                Time = "45 min.",
                Link = "Test_BFQ"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 5,
                NameTest = "16PF Forma A",
                Time = "60 min.",
                Link = "Test_16PF_A"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 6,
                NameTest = "16PF Forma B",
                Time = "60 min.",
                Link = "Test_16PF_B"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 7,
                NameTest = "IPV",
                Time = "60 min.",
                Link = "Test_IPV"
            });


            // Tabla de Puestos
            modelBuilder.Entity<Position>().HasData(new Position
            {
                IdPosition = 1,
                PositionName = "Desarrollador IT",
                PositionHigher = "Encargado de IT",
                Department = "Tecnología de la Información",
                CreationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            modelBuilder.Entity<Position>().HasData(new Position
            {
                IdPosition = 2,
                PositionName = "Asesor de Venta",
                PositionHigher = "Gerente Comercial",
                Department = "Ventas",
                CreationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            // Tabla de Usuario
            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 1,
                Name = "Werner Molina",
                Email = "Wm25@gmail.com",
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            // Tabla de Candidato
            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                IdCandidate = 1,
                IdPosition = 1,
                IdRole = 3,
                Email = "ml22002@esfe.agape.edu.sv",
                Password = "TW15",
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            // Tabla de Factores
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 1,
                FactorName = "Ascendencia",
                DescriptionFactor = "Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 2,
                FactorName = "Responsabilidad",
                DescriptionFactor = "Rasgo que alude a la constancia y perseverancia en las tareas propuestas."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 3,
                FactorName = "Estabilidad Emocional",
                DescriptionFactor = "Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 4,
                FactorName = "Sociabilidad",
                DescriptionFactor = "Rasgo que facilita el trato con los demás."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 5,
                FactorName = "Cautela",
                DescriptionFactor = "Cautela: Es el tipo de conducta caracterizada por prever las situaciones o efectos de una decisión antes de actuar."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 6,
                FactorName = "Originalidad",
                DescriptionFactor = "Originalidad: Rango de conducta que se manifiesta por la búsqueda de autenticidad en todo lo que hace."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 7,
                FactorName = "Comprensión",
                DescriptionFactor = "Comprensión: Grado en el cual somos capaces de interpretar o asimilar acontecimientos y hechos particulares o de la vida diaria."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 8,
                FactorName = "Vitalidad",
                DescriptionFactor = "Vitalidad: Se dice de la energía psíquica o física que se agrega a cada actividad que se emprende."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 9,
                FactorName = "Autoestima",
                DescriptionFactor = "Autoestima: Es la valoración positiva o negativa que uno hace de sí mismo."
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 10,
                FactorName = "Inteligencia",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 11,
                FactorName = "A",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 12,
                FactorName = "B",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 13,
                FactorName = "C",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 14,
                FactorName = "E",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 15,
                FactorName = "F",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 16,
                FactorName = "G",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 17,
                FactorName = "H",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 18,
                FactorName = "I",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 19,
                FactorName = "L",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 20,
                FactorName = "M",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 21,
                FactorName = "N",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 22,
                FactorName = "O",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 23,
                FactorName = "Q1",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 24,
                FactorName = "Q2",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 25,
                FactorName = "Q3",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 26,
                FactorName = "Q4",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 27,
                FactorName = "QI",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 28,
                FactorName = "QII",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 29,
                FactorName = "QIII",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 30,
                FactorName = "QIV",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 31,
                FactorName = "Disposición General para la Venta",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 32,
                FactorName = "Receptividad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 33,
                FactorName = "Agresividad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 34,
                FactorName = "I- Compresión",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 35,
                FactorName = "II- Adaptabilidad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 36,
                FactorName = "III- Control de sí mismo",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 37,
                FactorName = "IV- Tolerancia a la frustración",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 38,
                FactorName = "V- Combatividad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 39,
                FactorName = "VI- Dominio",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 40,
                FactorName = "VII- Seguridad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 41,
                FactorName = "VIII- Actividad",
                DescriptionFactor = ""
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 42,
                FactorName = "IX- Sociabilidad",
                DescriptionFactor = ""
            });


            // Tabla Intermedia de Roles y Usuarios
            modelBuilder.Entity<Role_User>().HasData(new Role_User
            {
                IdRole = 1,
                IdUser = 1
            });

            // Tabla Intermedia de Permisos y Roles
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 1
            });

            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 2
            });

            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 3
            });

            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 4
            });
        }

    }
}
