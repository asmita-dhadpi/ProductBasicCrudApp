using ProductCrudApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ProductCrudApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasIndex(p => new { p.Name, p.Category })
                .IsUnique();
        }
    }
}
