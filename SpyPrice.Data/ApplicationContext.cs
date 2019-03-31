using Microsoft.EntityFrameworkCore;
using SpyPrice.Data.Models;

namespace SpyPrice.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ItemCategory> ItemCategory { get; set; }

        public DbSet<Item> Item { get; set; }

        public DbSet<PriceLog> PriceLog { get; set; }

        public DbSet<RateLog> RateLog { get; set; }

        public ApplicationContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SpyPrice;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ItemCategory>()
                .HasIndex(u => u.Code)
                .IsUnique();
        }
    }
}
