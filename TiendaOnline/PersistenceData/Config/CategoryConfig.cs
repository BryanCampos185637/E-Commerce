using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace PersistenceData.Config
{
    public class CategoryConfig
    {
        public CategoryConfig(EntityTypeBuilder<Category>entity)
        {
            entity.HasKey(p => p.CategoryId);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(200);
            entity.Property(p => p.Description).IsRequired().HasMaxLength(200);
            entity.HasData(new Category 
            {
                CategoryId = 1, 
                Name = "Electronica", 
                Description = "Encontraras todo referente a aparatos electronicos",
                UserCreation="Inicio sistema",
                DateCreation=System.DateTime.UtcNow,
                Status=true
            },
                new Category 
                {
                    CategoryId = 2, 
                    Name = "Ropa para caballero", 
                    Description = "Ropa para el sexo masculino de todas las edades",
                    UserCreation = "Inicio sistema",
                    DateCreation = System.DateTime.UtcNow,
                    Status = true
                },
                new Category 
                { 
                    CategoryId = 3, 
                    Name = "Ropa para dama", 
                    Description = "Ropa para el sexo femenino de todas las edades",
                    UserCreation = "Inicio sistema",
                    DateCreation = System.DateTime.UtcNow,
                    Status = true
                });
        }
    }
}
