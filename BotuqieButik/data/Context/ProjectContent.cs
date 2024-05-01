using BotuqieButik.data.Config;
using BotuqieButik.data.Entitis;
using Microsoft.EntityFrameworkCore;

namespace BotuqieButik.data.Context
{
    public class ProjectContent:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(x => x.UserName).IsUnique();
            modelBuilder.Entity<User>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<User>().Property(x => x.UserName).HasMaxLength(12);
            modelBuilder.Entity<User>().HasKey(x => x.Id);


            modelBuilder.ApplyConfiguration(new RoleConfig());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V2NDUGD;Database=ButikDb;Trusted_Connection=True;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
