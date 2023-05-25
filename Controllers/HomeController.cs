using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using workshop.Models;

namespace workshop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var list = new List<HomeVm>() {
            new HomeVm(){Id =1, Name ="Abc", Address ="btm" },
            new HomeVm(){Id =2, Name ="Ram", Address ="ktm" }
            };
            return View(list);
        }
        [HttpGet]
        public IActionResult New()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult naya()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}