using Microsoft.AspNetCore.Mvc;
using CS.Models;

namespace MyAspNetApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var msg = new Message { Content = "Chào mừng đến với ASP.NET Core MVC!" };
            return View(msg);
        }
    }
}
