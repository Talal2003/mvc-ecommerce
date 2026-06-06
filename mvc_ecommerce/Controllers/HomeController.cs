using Microsoft.AspNetCore.Mvc;
using mvc_ecommerce.Data;
using mvc_ecommerce.Models;
using System.Diagnostics;

namespace mvc_ecommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ApplicationDbContext context = new ApplicationDbContext();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.categories = context.Categories.ToList();
            ViewBag.products = context.Products.ToList();
            return View();
        }

        public IActionResult Privacy()
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
