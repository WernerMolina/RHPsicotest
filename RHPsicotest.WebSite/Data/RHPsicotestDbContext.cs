using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Models;
using System;
using System.Globalization;

namespace RHPsicotest.WebSite.Data
{
    public class RHPsicotestDbContext : DbContext
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

        public RHPsicotestDbContext(DbContextOptions<RHPsicotestDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);


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
                        .HasKey(r => new { r.IdExpedient, r.IdTest, r.IdFactor});
            
            modelBuilder.Entity<Test_Candidate>()
                        .HasKey(r => new { r.IdCandidate, r.IdTest});


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
                NameTest = "16PF",
                Time = "45 min.",
                Link = "Test_16PF"
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
                FactorName = "Asc.",
                DescriptionFactor = "Ascendencia: Rasgo que se refiere a la dominancia e iniciativa en situaciones de grupo."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 2,
                FactorName = "Resp.",
                DescriptionFactor = "Responsabilidad: Rasgo que alude a la constancia y perseverancia en las tareas propuestas."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 3,
                FactorName = "Estab.",
                DescriptionFactor = "Estabilidad Emocional: Rasgo que refleja la ausencia de hipersensibilidad, ansiedad y tensión nerviosa."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 4,
                FactorName = "Soc.",
                DescriptionFactor = "Sociabilidad: Rasgo que facilita el trato con los demás."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 5,
                FactorName = "Caut.",
                DescriptionFactor = "Cautela: Es el tipo de conducta caracterizada por prever las situaciones o efectos de una decisión antes de actuar."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 6,
                FactorName = "Orig.",
                DescriptionFactor = "Originalidad: Rango de conducta que se manifiesta por la búsqueda de autenticidad en todo lo que hace."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 7,
                FactorName = "Comp.",
                DescriptionFactor = "Comprensión: Grado en el cual somos capaces de interpretar o asimilar acontecimientos y hechos particulares o de la vida diaria."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 8,
                FactorName = "Vital.",
                DescriptionFactor = "Vitalidad: Se dice de la energía psíquica o física que se agrega a cada actividad que se emprende."
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 9,
                FactorName = "Autoest.",
                DescriptionFactor = "Autoestima: Es la valoración positiva o negativa que uno hace de sí mismo."
            });
            
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 10,
                FactorName = "Inteligencia",
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
