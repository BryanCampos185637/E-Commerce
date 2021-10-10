using Microsoft.AspNetCore.Mvc;

namespace UserInterface.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
