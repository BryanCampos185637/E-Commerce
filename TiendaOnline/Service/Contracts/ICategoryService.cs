using Model.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface ICategoryService
    {
        Task<List<CategoryDTO>> GetAll();
    }
}
