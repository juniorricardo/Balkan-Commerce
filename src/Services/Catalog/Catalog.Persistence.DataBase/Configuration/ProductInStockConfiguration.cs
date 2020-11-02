using System;
using System.Collections.Generic;
using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class ProductInStockConfiguration : IEntityTypeConfiguration<ProductInStock>
    {
        public void Configure(EntityTypeBuilder<ProductInStock> builder)
        {
            builder.HasKey(x => x.ProductInStockId);

            // 
            var products = new List<ProductInStock>();
            var random = new Random();

            for (var i = 1; i <= 100; i++)
                products.Add(new ProductInStock {ProductInStockId = i, ProductId = i, Stock = random.Next(0, 100)});

            builder.HasData(products);
        }
    }
}