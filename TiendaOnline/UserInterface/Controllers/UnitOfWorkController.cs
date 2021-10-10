using BussinessLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace UserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitOfWorkController : ControllerBase
    {

        private IUnitOfWork unitOfWork;
        protected IUnitOfWork _UnitOfWork => unitOfWork ?? (unitOfWork = HttpContext.RequestServices.GetService<IUnitOfWork>());
    }
}
