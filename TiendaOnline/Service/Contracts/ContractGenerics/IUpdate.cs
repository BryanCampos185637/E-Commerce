using System.Threading.Tasks;

namespace Service.Contracts.ContractGenerics
{
    public interface IUpdate<T> where T:class
    {
        Task Update(T model);
    }
}
