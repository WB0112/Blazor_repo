using Microsoft.EntityFrameworkCore;

namespace ProductAPI.DbAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Models.Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Models.Product>().Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Models.User>().HasKey(u => u.Id);
            modelBuilder.Entity<Models.User>().Property(u => u.Username).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Models.User>().Property(u => u.Password).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Models.User>().Property(u => u.Role).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<Models.User>().Property(u => u.Email).IsRequired().HasMaxLength(50);
            //seed data
            modelBuilder.Entity<Models.Product>().HasData(
                new Models.Product { Id = 1, Name = "Laptop", Price = 10.00M },
                new Models.Product { Id = 2, Name = "Smartphone", Price = 20.00M },
                new Models.Product { Id = 3, Name = "Tablet", Price = 30.00M }
            );
            //seed user data
            modelBuilder.Entity<Models.User>().HasData(
                new Models.User { Id = "U0001", Username = "admin", Password = "admin123", Role = "Admin", Email = "admin@gmail.com" },
                new Models.User { Id = "U0002", Username = "user", Password = "user123", Role = "User", Email = "user@gmail.com" }
            );
        }
    }
}
