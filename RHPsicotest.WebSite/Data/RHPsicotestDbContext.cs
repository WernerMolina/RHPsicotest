using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Models;
using System;

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
        public DbSet<Question> Questions { get; set; }

        public DbSet<Result> Results { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Role_User> Role_Users { get; set; }
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
            
            modelBuilder.Entity<Response>()
                        .HasKey(r => new { r.IdFactor, r.IdQuestion });
            
            modelBuilder.Entity<Result>()
                        .HasKey(r => new { r.IdExpedient, r.IdFactor});


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
            });

            // Tabla de Puestos
            modelBuilder.Entity<Position>().HasData(new Position
            {
                IdPosition = 1,
                IdTest = 1,
                PositionName = "Desarrollador IT",
                PositionHigher = "Encargado de IT",
                Department = "Tecnología de la Información",
                CreationDate = DateTime.Now.Date
            });
            
            modelBuilder.Entity<Position>().HasData(new Position
            {
                IdPosition = 2,
                IdTest = 1,
                PositionName = "Asesor de Venta",
                PositionHigher = "Gerente Comercial",
                Department = "Ventas",
                CreationDate = DateTime.Now.Date
            });

            // Tabla de Usuario
            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 1,
                Name = "Werner Molina",
                Email = "Wm25@gmail.com",
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now.Date
            });

            // Tabla de Candidato
            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                IdCandidate = 1,
                IdPosition = 1,
                IdRole = 3,
                Username = "WerMolina",
                Email = "ml22002@esfe.agape.edu.sv",
                Password = "TW15",
                RegistrationDate = DateTime.Now.Date
            });

            // Tabla de Factores
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 1,
                NameFactor = "Ascendencia",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 2,
                NameFactor = "Responsabilidad",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 3,
                NameFactor = "Estabilidad Emocional",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 4,
                NameFactor = "Sociabilidad",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 5,
                NameFactor = "Cautela",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 6,
                NameFactor = "Originalidad",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 7,
                NameFactor = "Comprension",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 8,
                NameFactor = "Vitalidad",
            });

            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 9,
                NameFactor = "Autoestima",
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
