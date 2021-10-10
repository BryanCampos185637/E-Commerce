using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Security;
using PersistenceData.Config;

namespace PersistenceData
{
    public class AplicationDbContext:IdentityDbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new SupplierConfig(builder.Entity<Supplier>());
            new AplicationRolConfig(builder.Entity<AplicationRol>());
            new AplicationUserConfig(builder.Entity<AplicationUser>());
            new CategoryConfig(builder.Entity<Category>());
            new ProductConfig(builder.Entity<Product>());
        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Supplier>Suppliers { get; set; }

    }
}
