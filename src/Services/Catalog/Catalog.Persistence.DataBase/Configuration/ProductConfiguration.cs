using System;
using System.Collections.Generic;
using System.Linq;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasIndex(x => x.ProductId);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
            
            // Products by default
            var products = new List<Product>();
            var random = new Random();
            
            for (var i = 1; i <= 100; i++)
                products.Add(new Product
                {
                    ProductId = i,
                    Name = $"Product {i}",
                    Description = $"Description for product {i}",
                    Price = random.Next(100, 1000),
                    Stock = new ProductInStock {ProductInStockId = i, ProductId = i, Stock = random.Next(0, 100)}
                });

            builder.HasData(products);
        }
    }
}