using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet] // Action to display/get the initial form
        public IActionResult Index()
        {
            ViewBag.discount = 0;
            ViewBag.total = 0; 
            return View();
        }

        [HttpPost] // Action to handle the form submission
        public IActionResult Index(PriceQuote model)
        {
            ViewBag.discount = 0;
            ViewBag.total = 0;
            return View(model);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
