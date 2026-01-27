using Microsoft.EntityFrameworkCore;

namespace ProductAPI.DbAccess
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Models.Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Models.Product>().Property(p => p.Name).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Models.Product>().Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            //seed data
            modelBuilder.Entity<Models.Product>().HasData(
                new Models.Product { Id = 1, Name = "Laptop", Price = 10.00M },
                new Models.Product { Id = 2, Name = "Smartphone", Price = 20.00M },
                new Models.Product { Id = 3, Name = "Tablet", Price = 30.00M }
            );
        }
    }
}
