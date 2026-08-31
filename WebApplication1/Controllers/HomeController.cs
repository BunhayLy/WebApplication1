using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AgeCalculatorViewModel());
        }

        [HttpPost]
        public IActionResult Index(AgeCalculatorViewModel model)
        {
            model.Age = DateTime.Now.Year - model.BirthYear;
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}