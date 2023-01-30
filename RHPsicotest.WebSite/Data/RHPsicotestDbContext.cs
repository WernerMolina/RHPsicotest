using Microsoft.EntityFrameworkCore;
using RHPsicotest.WebSite.Models;
using System;

namespace RHPsicotest.WebSite.Data
{
    public class RHPsicotestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<EmailUser> EmailUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Stall> Stalls { get; set; }
        public DbSet<Expedient> Expedients { get; set; }
        public DbSet<Permission_Role> Permission_Roles { get; set; }
        public DbSet<Role_User> Role_Users { get; set; }

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


            //modelBuilder.Entity<Permission>().HasData(new Permission
            //{
            //    IdPermission = 1,
            //    PermissionName = "Lista-Usuarios",
            //});

            //modelBuilder.Entity<Permission>().HasData(new Permission
            //{
            //    IdPermission = 2,
            //    PermissionName = "Crear-Usuario",
            //});

            //modelBuilder.Entity<Permission>().HasData(new Permission
            //{
            //    IdPermission = 3,
            //    PermissionName = "Editar-Usuario",
            //});

            //modelBuilder.Entity<Permission>().HasData(new Permission
            //{
            //    IdPermission = 4,
            //    PermissionName = "Eliminar-Usuario",
            //});

            //modelBuilder.Entity<Role>().HasData(new Role
            //{
            //    IdRole = 1,
            //    RoleName = "Super-Admin",
            //});

            //modelBuilder.Entity<User>().HasData(new User
            //{
            //    IdUser = 1,
            //    Name = "Werner Molina",
            //    Email = "Wm25@gmail.com",
            //    Password = "827ccb0eea8a706c4c34a16891f84e7b",
            //    RegistrationDate = DateTime.Now.Date
            //});

            //modelBuilder.Entity<Role_User>().HasData(new Role_User
            //{
            //    IdRole = 1,
            //    IdUser = 1
            //});

            //modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            //{
            //    IdRole = 1,
            //    IdPermission = 1
            //});

            //modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            //{
            //    IdRole = 1,
            //    IdPermission = 2
            //});

            //modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            //{
            //    IdRole = 1,
            //    IdPermission = 3
            //});

            //modelBuilder.Entity<Permission_Role>().HasData(new Permission_Role
            //{
            //    IdRole = 1,
            //    IdPermission = 4
            //});
        }
    }
}
