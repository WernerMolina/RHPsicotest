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

            modelBuilder.Entity<Role_User>()
                        .HasOne(ru => ru.User)
                        .WithMany(u => u.Role_Users)
                        .HasForeignKey(ru => ru.IdUser);

            modelBuilder.Entity<Role_User>()
                        .HasOne(ru => ru.Role)
                        .WithMany(r => r.Role_Users)
                        .HasForeignKey(ru => ru.IdRole);

            modelBuilder.Entity<Role>().HasData(new Role
            {
                IdRole = 1,
                RoleName = "Administrador"
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 3,
                IdRole = 1,
                Name = "Werner Molina",
                Email = "Wm25@gmail.com",
                Password = "827ccb0eea8a706c4c34a16891f84e7b",
                RegistrationDate = DateTime.Now
            });

            modelBuilder.Entity<Role_User>().HasData(new Role_User
            {
                Id = 1,
                IdRole = 1,
                IdUser = 3
            });
        }
    }
}
