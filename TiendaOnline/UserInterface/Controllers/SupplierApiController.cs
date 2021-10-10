using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using UserInterface.Models;

namespace UserInterface.Controllers
{
    public class SupplierApiController : UnitOfWorkController
    {
        [HttpGet]
        public async Task<ApiResult> get()
        {
            return new ApiResult(await _UnitOfWork.SupplierService().GetAll());
        }
    }
}
