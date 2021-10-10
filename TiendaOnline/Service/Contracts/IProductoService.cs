using Model;
using Model.DTO;
using Service.Contracts.ContractGenerics;

namespace Service.Contracts
{
    public interface IProductoService:IAdd<Product>,IUpdate<Product>,IDelete,IPagination<ProductDTO>,IFindById<ProductDTO>
    {
    }
}
