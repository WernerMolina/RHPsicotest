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
        public DbSet<Module> Modules { get; set; }
        public DbSet<Role_User> Role_Users { get; set; }
        public DbSet<Stall> Stalls { get; set; }

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

            modelBuilder.Entity<Permission>()
                        .HasOne(p => p.Module)
                        .WithMany(m => m.Permissions)
                        .HasForeignKey(p => p.IdModule);

            modelBuilder.Entity<Role>()
                        .HasOne(r => r.Permission)
                        .WithMany(p => p.Roles)
                        .HasForeignKey(r => r.IdPermission);

            modelBuilder.Entity<Role_User>()
                        .HasKey(ru => new { ru.IdRole, ru.IdUser });

            modelBuilder.Entity<Role_User>()
                        .HasOne(ru => ru.Role)
                        .WithMany(r => r.Role_Users)
                        .HasForeignKey(ru => ru.IdRole);
            
            modelBuilder.Entity<Role_User>()
                        .HasOne(ru => ru.User)
                        .WithMany(u => u.Role_Users)
                        .HasForeignKey(ru => ru.IdUser);

            modelBuilder.Entity<Module>().HasData(new Module
            {
                IdModule = 1,
                ModuleName = "Pues no se"
            });

            modelBuilder.Entity<Permission>().HasData(new Permission
            {
                IdPermission = 1,
                IdModule = 1,
                PermissionName = "Todo",
            });

            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 1,
                IdPermission = 1,
                RoleName = "Super-Admin",
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 1,
                Name = "Werner Molina",
                Email = "Wm25@gmail.com",
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now
            });

            modelBuilder.Entity<Role_User>().HasData(new Role_User
            {
                IdRole = 1,
                IdUser = 1
            });
        }
    }
}
