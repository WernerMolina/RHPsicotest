using Microsoft.EntityFrameworkCore;

namespace RHPsicotest.WebSite.Models
{
    public class RHPsicotestDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

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

            modelBuilder.Entity<User>().HasData(new User
            {
                IdUser = 1,
                RoleName = "Administrador",
                Name = "Werner",
                LastName = "Molina",
                Email = "Wm25@gmail.com",
                Password = "827ccb0eea8a706c4c34a16891f84e7b"
            });
        }
    }
}
