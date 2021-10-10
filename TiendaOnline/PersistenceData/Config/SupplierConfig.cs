using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace PersistenceData.Config
{
    public class SupplierConfig
    {
        public SupplierConfig(EntityTypeBuilder<Supplier>entity)
        {
            entity.HasKey(p => p.SupplierId);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Email).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Phone).IsRequired().HasMaxLength(20);
        }
    }
}
