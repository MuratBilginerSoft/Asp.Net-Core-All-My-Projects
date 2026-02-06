using Microsoft.AspNetCore.Mvc;

namespace DeveloperEng_App.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
