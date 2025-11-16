using Microsoft.EntityFrameworkCore;
using PharmacyManagement.Models;

namespace PharmacyManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // تنظیم precision برای Price
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            // Seed some initial data
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "پاراستامول",
                    Description = "مسکن و تب‌بر",
                    Price = 5000.00m,
                    StockQuantity = 100,
                    ProductionDate = new DateTime(2024, 1, 1),
                    ExpiryDate = new DateTime(2026, 1, 1),
                    Manufacturer = "داروسازی سبحان",
                    Category = "مسکن",
                    CreatedAt = new DateTime(2024, 1, 1),
                    UpdatedAt = new DateTime(2024, 1, 1)
                },
                new Product
                {
                    Id = 2,
                    Name = "آموکسی سیلین",
                    Description = "آنتی بیوتیک",
                    Price = 15000.00m,
                    StockQuantity = 50,
                    ProductionDate = new DateTime(2024, 2, 1),
                    ExpiryDate = new DateTime(2026, 2, 1),
                    Manufacturer = "داروسازی کیمیدارو",
                    Category = "آنتی بیوتیک",
                    CreatedAt = new DateTime(2024, 1, 1),
                    UpdatedAt = new DateTime(2024, 1, 1)
                }
            );
        }
    }
}