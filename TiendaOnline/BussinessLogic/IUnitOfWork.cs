
using Service.Services;
using System.Threading.Tasks;

namespace BussinessLogic
{
    public interface IUnitOfWork
    {
        int SaveChange();
        Task<int> SaveChangeAsync();
        Microsoft.EntityFrameworkCore.Storage.IDbContextTransaction BegingTransaction();
        ProductoService ProductoService();
        CategoryService categoryService();
        SupplierService SupplierService();
    }
}
