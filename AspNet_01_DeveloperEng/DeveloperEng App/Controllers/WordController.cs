using DeveloperEng_App.DataContext;
using DeveloperEng_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DeveloperEng_App.Controllers
{
    public class WordController : Controller
    {
        private readonly MyContext _context;

        public WordController(MyContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var words = _context.Words.ToList();    
            return View(words);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Word word)
        {
            if (ModelState.IsValid)
            {
                _context.Words.Add(word);
                _context.SaveChanges();
                TempData["message"] = "Word Created Successfully";
                return RedirectToAction("Create");
            }
            return View(word);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var word = _context.Words.Find(id);

            if (word == null)
            {
                return RedirectToAction("Index");
            }

            return View(word);
        }

        [HttpPost]
        public IActionResult Edit(Word word)
        {

            if (ModelState.IsValid)
            {
                _context.Words.Update(word);
                _context.SaveChanges();
                TempData["message"] = "Word Updated Successfully";
                return RedirectToAction("Edit", new { id = word.Id });
            }
            return View(word);
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var word = _context.Words.Find(id);

            Console.WriteLine(word?.Id);

            if (word == null)
            {
                return NotFound();
            }

            _context.Words.Remove(word);
            _context.SaveChanges();

            return Ok(); // Başarı durum kodu döner

        }
    }
}
