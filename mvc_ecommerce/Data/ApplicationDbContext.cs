using Microsoft.EntityFrameworkCore;
using mvc_ecommerce.Models;

namespace mvc_ecommerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=.;Database=MVC14;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                
                new Category() { Id = 1, Name = "Mobiles"},
                new Category() { Id = 2, Name = "Tablets" },
                new Category() { Id = 3, Name = "Laptops" }
                );
            modelBuilder.Entity<Product>().HasData(

                new Product() { Id = 1, Name = "Product 1", Description = "This is product 1", Price = 300, Quantity = 100, CategoryId = 1 },
                new Product() { Id = 2, Name = "Product 2", Description = "This is product 2", Price = 100, Quantity = 55, CategoryId = 1 },
                new Product() { Id = 3, Name = "Product 3", Description = "This is product 3", Price = 200, Quantity = 20, CategoryId = 1 }
                );
        }
    }
}
