using BotuqieButik.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BotuqieButik.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult sepet()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ustgiyim()
        {
            return View();
        }

        public IActionResult altgiyim()
        {
            return View();
        }

        public IActionResult disgiyim()
        {
            return View();
        }

        public IActionResult ozelfiyatlar()
        {
            return View();
        }

        public IActionResult yenigelenler()
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
