using Microsoft.AspNetCore.Mvc;

namespace DeveloperEng_App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
