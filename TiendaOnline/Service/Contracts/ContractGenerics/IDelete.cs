using System.Threading.Tasks;

namespace Service.Contracts.ContractGenerics
{
    public interface IDelete
    {
        Task Delete(int id);
    }
}
