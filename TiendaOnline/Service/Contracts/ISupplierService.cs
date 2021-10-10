using Model.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ISupplierService
    {
        Task<List<SupplierDTO>> GetAll();
    }
}
