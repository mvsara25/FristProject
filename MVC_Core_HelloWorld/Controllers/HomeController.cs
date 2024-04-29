using Microsoft.AspNetCore.Mvc;

namespace MVC_Core_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "This is my First MVC Core 7 App.";
            return View();
        }
    }
}
