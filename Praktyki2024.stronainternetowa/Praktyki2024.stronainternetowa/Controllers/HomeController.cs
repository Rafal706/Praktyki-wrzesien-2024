using Microsoft.AspNetCore.Mvc;
using Praktyki2024.stronainternetowa.Models;
using System.Diagnostics;

namespace Praktyki2024.stronainternetowa.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult Strona1()
        {
            var statystyki = new Strona1(
                "Mercedes",
                "czerowny",
                2007,
                "Nowy",
                "Niemcy"
            );

            return View(statystyki);
        }
        public IActionResult Strona2()
        {
            var statystyki = new Strona2(
                "Fiat",
                "zielony",
                2000,
                "U¿ywany",
                "Polska"
            );

            return View(statystyki);
        }
        public IActionResult Strona3()
        {
            var statystyki = new Strona3(
                "BMW",
                "czarny",
                2017,
                "Nowy",
                "Niemcy"
            );

            return View(statystyki);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
