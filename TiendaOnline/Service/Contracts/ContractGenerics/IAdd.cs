using System.Threading.Tasks;

namespace Service.Contracts.ContractGenerics
{
    public interface IAdd<T> where T:class
    {
        Task Add(T model);
    }
}
