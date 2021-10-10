using System.Threading.Tasks;

namespace Service.Contracts.ContractGenerics
{
    public interface IFindById<T> where T:class
    {
        Task<T> FindById(int id);
    }
}
