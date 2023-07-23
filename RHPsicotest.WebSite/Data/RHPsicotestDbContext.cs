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
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 2,
                PermissionName = "Crear-Usuario",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 3,
                PermissionName = "Editar-Usuario",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 4,
                PermissionName = "Eliminar-Usuario",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 5,
                PermissionName = "Lista-Roles",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 6,
                PermissionName = "Crear-Rol",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 7,
                PermissionName = "Editar-Role",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 8,
                PermissionName = "Eliminar-Rol",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 9,
                PermissionName = "Lista-Candidatos",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 10,
                PermissionName = "Crear-Candidato",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 11,
                PermissionName = "Eliminar-Candidato",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 12,
                PermissionName = "Reenviar-Correo",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 13,
                PermissionName = "Lista-Expedientes",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 14,
                PermissionName = "Editar-Expediente",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 15,
                PermissionName = "Ver-Curriculums",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 16,
                PermissionName = "Ver-Reportes",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 17,
                PermissionName = "Lista-Puestos",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 18,
                PermissionName = "Crear-Puesto",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 19,
                PermissionName = "Editar-Puesto",
                Assigned = "Adminitradores",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 20,
                PermissionName = "Eliminar-Puesto",
                Assigned = "Adminitradores"
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 21,
                PermissionName = "Crear-Expediente",
                Assigned = "Candidatos",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 22,
                PermissionName = "Confirmar-Politicas",
                Assigned = "Candidatos",
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 23,
                PermissionName = "Pruebas-Asignadas",
                Assigned = "Candidatos",
            });

            // Tabla de Roles
            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 1,
                RoleName = "Super-Admin",
                RoleNameNormalized = "Super-Admin".ToUpper(),
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 2,
                RoleName = "Candidato",
                RoleNameNormalized = "Candidato".ToUpper(),
            });
            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 3,
                RoleName = "Administrador",
                RoleNameNormalized = "Administrador".ToUpper(),
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
                EmailNormalized = "Wm25@gmail.com".ToUpper(),
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            // Tabla de Candidato
            modelBuilder.Entity<Candidate>().HasData(new Candidate
            {
                IdCandidate = 1,
                IdPosition = 1,
                IdRole = 2,
                Email = "ml22002@esfe.agape.edu.sv",
                EmailNormalized = "ml22002@esfe.agape.edu.sv".ToUpper(),
                Password = "TW15",
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });

            // Tabla de Factores
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 1,
                FactorName = "Ascendencia",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 2,
                FactorName = "Responsabilidad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 3,
                FactorName = "Estabilidad Emocional",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 4,
                FactorName = "Sociabilidad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 5,
                FactorName = "Cautela",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 6,
                FactorName = "Originalidad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 7,
                FactorName = "Comprensión",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 8,
                FactorName = "Vitalidad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 9,
                FactorName = "Autoestima",
            });           
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 10,
                FactorName = "Inteligencia",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 11,
                FactorName = "A",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 12,
                FactorName = "B",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 13,
                FactorName = "C",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 14,
                FactorName = "E",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 15,
                FactorName = "F",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 16,
                FactorName = "G",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 17,
                FactorName = "H",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 18,
                FactorName = "I",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 19,
                FactorName = "L",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 20,
                FactorName = "M",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 21,
                FactorName = "N",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 22,
                FactorName = "O",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 23,
                FactorName = "Q1",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 24,
                FactorName = "Q2",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 25,
                FactorName = "Q3",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 26,
                FactorName = "Q4",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 27,
                FactorName = "QI",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 28,
                FactorName = "QII",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 29,
                FactorName = "QIII",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 30,
                FactorName = "QIV",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 31,
                FactorName = "Disposición General para la Venta",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 32,
                FactorName = "Receptividad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 33,
                FactorName = "Agresividad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 34,
                FactorName = "I- Compresión",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 35,
                FactorName = "II- Adaptabilidad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 36,
                FactorName = "III- Control de sí mismo",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 37,
                FactorName = "IV- Tolerancia a la frustración",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 38,
                FactorName = "V- Combatividad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 39,
                FactorName = "VI- Dominio",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 40,
                FactorName = "VII- Seguridad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 41,
                FactorName = "VIII- Actividad",
            });
            modelBuilder.Entity<Factor>().HasData(new Factor
            {
                IdFactor = 42,
                FactorName = "IX- Sociabilidad",
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
