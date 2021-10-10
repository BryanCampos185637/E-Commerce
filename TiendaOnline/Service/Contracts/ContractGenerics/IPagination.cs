using Model.DTO.Pagination;
using System.Threading.Tasks;

namespace Service.Contracts.ContractGenerics
{
    public interface IPagination<T>where T:class
    {
        Task<DataCollection<T>> Pagination(DataCollection<T> model);
    }
}
