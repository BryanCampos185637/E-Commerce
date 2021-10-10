using Microsoft.AspNetCore.Mvc;

namespace UserInterface.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
