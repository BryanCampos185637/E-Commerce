using Microsoft.EntityFrameworkCore.Storage;
using PersistenceData;
using Service.Services;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AplicationDbContext db;
        public UnitOfWork(AplicationDbContext context)
        {
            db = context;
        }

        public IDbContextTransaction BegingTransaction()
        {
            return db.Database.BeginTransaction();
        }

        public CategoryService categoryService()
        {
            return new CategoryService(db);
        }

        public ProductoService ProductoService()
        {
            return new ProductoService(db);
        }

        public int SaveChange()
        {
            return db.SaveChanges();
        }

        public Task<int> SaveChangeAsync()
        {
            return db.SaveChangesAsync();
        }

        public SupplierService SupplierService()
        {
            return new SupplierService(db);
        }
    }
}
