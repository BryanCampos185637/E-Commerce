using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace PersistenceData.Config
{
    public class ProductConfig
    {
        public ProductConfig(EntityTypeBuilder<Product>entity)
        {
            entity.HasKey(p => p.ProductId);
            entity.Property(p => p.Code).HasMaxLength(128).IsRequired();
            entity.Property(p => p.Description).HasMaxLength(200).IsRequired();
            entity.Property(p => p.Name).HasMaxLength(200).IsRequired();
            entity.Property(p => p.Price).IsRequired().HasColumnType("decimal(16,2)");
            entity.Property(p => p.Quantity).IsRequired();
        }
    }
}
