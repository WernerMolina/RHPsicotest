﻿using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Models;
using System;
using System.Globalization;

namespace RHPsicotest.WebSite.Data
{
    public class RHPV2DbContext : DbContext
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

        public RHPV2DbContext(DbContextOptions<RHPV2DbContext> options) : base(options)
        {

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
                PermissionName = "Ver Lista de Usuarios",
                PermissionNamePolicy = "Lista-Usuarios",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 2,
                PermissionName = "Crear Usuarios",
                PermissionNamePolicy = "Crear-Usuario",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 3,
                PermissionName = "Editar Usuarios",
                PermissionNamePolicy = "Editar-Usuario",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 4,
                PermissionName = "Eliminar Usuarios",
                PermissionNamePolicy = "Eliminar-Usuario",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 5,
                PermissionName = "Ver Lista de Roles",
                PermissionNamePolicy = "Lista-Roles",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 6,
                PermissionName = "Crear Roles",
                PermissionNamePolicy = "Crear-Rol",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 7,
                PermissionName = "Editar Roles",
                PermissionNamePolicy = "Editar-Rol",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 8,
                PermissionName = "Eliminar Roles",
                PermissionNamePolicy = "Eliminar-Rol",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 9,
                PermissionName = "Ver Lista de Candidatos",
                PermissionNamePolicy = "Lista-Candidatos",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 10,
                PermissionName = "Crear Candidatos",
                PermissionNamePolicy = "Crear-Candidato",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 11,
                PermissionName = "Eliminar Candidatos",
                PermissionNamePolicy = "Eliminar-Candidato",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 12,
                PermissionName = "Reenviar Correos",
                PermissionNamePolicy = "Reenviar-Correo",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 13,
                PermissionName = "Ver Lista de Expedientes",
                PermissionNamePolicy = "Lista-Expedientes",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 14,
                PermissionName = "Editar Expedientes",
                PermissionNamePolicy = "Editar-Expediente",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 15,
                PermissionName = "Ver Curriculums",
                PermissionNamePolicy = "Ver-Curriculums",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 16,
                PermissionName = "Ver Reportes",
                PermissionNamePolicy = "Ver-Reportes",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 17,
                PermissionName = "Ver Lista de Puestos",
                PermissionNamePolicy = "Lista-Puestos",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 18,
                PermissionName = "Crear Puestos",
                PermissionNamePolicy = "Crear-Puesto",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 19,
                PermissionName = "Editar Puestos",
                PermissionNamePolicy = "Editar-Puesto",
                Assigned = "Administradores",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 20,
                PermissionName = "Eliminar Puestos",
                PermissionNamePolicy = "Eliminar-Puesto",
                Assigned = "Administradores"
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 21,
                PermissionName = "Crear Expediente",
                PermissionNamePolicy = "Crear-Expediente",
                Assigned = "Candidatos",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 22,
                PermissionName = "Confirmar Políticas",
                PermissionNamePolicy = "Confirmar-Politicas",
                Assigned = "Candidatos",
            });
            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 23,
                PermissionName = "Pruebas Asignadas",
                PermissionNamePolicy = "Pruebas-Asignadas",
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
                Time = "60 min.",
                Link = "Test_Dominos"
            });
            modelBuilder.Entity<Test>().HasData(new Test
            {
                IdTest = 4,
                NameTest = "IPV",
                Time = "45 min.",
                Link = "Test_IPV"
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
            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 2,
                Name = "Rosy Hernández",
                Email = "rosy.vasquez@consulightpf.net",
                EmailNormalized = "rosy.vasquez@consulightpf.net".ToUpper(),
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt", CultureInfo.CreateSpecificCulture("en-En"))
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 3,
                Name = "Roberto",
                Email = "roberto.ramirez@consulightpf.net",
                EmailNormalized = "roberto.ramirez@consulightpf.net".ToUpper(),
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
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
            modelBuilder.Entity<Role_User>().HasData(new Role_User
            {
                IdRole = 1,
                IdUser = 2
            });
            modelBuilder.Entity<Role_User>().HasData(new Role_User
            {
                IdRole = 1,
                IdUser = 3
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
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 5
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 6
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 7
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 8
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 9
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 10
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 11
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 12
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 13
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 14
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 15
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 16
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 17
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 18
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 19
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 1,
                IdPermission = 20
            });

            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 2,
                IdPermission = 21
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 2,
                IdPermission = 22
            });
            modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            {
                IdRole = 2,
                IdPermission = 23
            });

        }

    }
}
