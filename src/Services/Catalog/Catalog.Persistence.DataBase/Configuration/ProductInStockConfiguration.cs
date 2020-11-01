using Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.DataBase.Configuration
{
    public class ProductInStockConfiguration:IEntityTypeConfiguration<ProductInStock>
    {
        public void Configure(EntityTypeBuilder<ProductInStock> builder)
        {
            builder.HasKey(x => x.ProductInStockId);
        }
    }
}