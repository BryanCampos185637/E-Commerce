using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserInterface.Controllers
{
    public class StoredController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
