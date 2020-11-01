using System;
using Catalog.Domain;
using Catalog.Persistence.DataBase.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.DataBase
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() { }
        
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductInStock> Stocks { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            //DataBase schema
            modelBuilder.HasDefaultSchema("Catalog");
            
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInStockConfiguration());
        }
    }
}