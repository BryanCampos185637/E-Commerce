using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Security;
using System;

namespace PersistenceData.Config
{
    public class AplicationRolConfig
    {
        public AplicationRolConfig(EntityTypeBuilder<AplicationRol>entityType)
        {
            entityType.HasMany(p => p.UserRoles).WithOne(p => p.Rol).HasForeignKey(p => p.RoleId).IsRequired();

            //data inicial
            entityType.HasData(new AplicationRol
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "Administrador"
            },
            new AplicationRol
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Vendedor",
                NormalizedName = "Vendedor"
            });

        }
    }
}
