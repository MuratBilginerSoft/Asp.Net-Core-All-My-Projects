using DeveloperEng_App.DataContext;
using DeveloperEng_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperEng_App.Controllers
{
    public class AuthController : Controller
    {
        private readonly MyContext _context;

        public AuthController(MyContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(string email, string password)
        {
            var authentication = _context.Authentications.FirstOrDefault(x => x.Email == email && x.Password == password);

            if (authentication == null)
            {
                TempData["ErrorMessage"] = "Email or Password Is Wrong";
                return RedirectToAction("SignIn");
            }

            return RedirectToAction("Index", "Dashboard");
            
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(string email, string password)
        {
            var authUser = _context.Authentications.FirstOrDefault(x => x.Email == email);

            if (authUser != null)
            {
                TempData["ErrorMessage"] = "Email Already Exist";
                return RedirectToAction("SignUp");
            }

            else
            {
                var authentication = new Authentication
                {
                    Email = email,
                    Password = password
                };

                _context.Authentications.Add(authentication);
                _context.SaveChanges();

                TempData["SuccessMessage"] = "Create User Successfully";
                return RedirectToAction("SignIn");

            }

        }
    }
}
