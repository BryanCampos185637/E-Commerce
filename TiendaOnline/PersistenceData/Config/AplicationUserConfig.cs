using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Security;

namespace PersistenceData.Config
{
    public class AplicationUserConfig
    {
        public AplicationUserConfig(EntityTypeBuilder<AplicationUser>entity)
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Age).IsRequired();
            entity.Property(p => p.DateOfBirth).IsRequired().HasColumnType("date");
            entity.HasMany(p => p.UserRoles).WithOne(p => p.User).HasForeignKey(p => p.UserId).IsRequired();
        }
    }
}
