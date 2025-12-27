using DemoVendorApplicationMVC.Interfaces;
using DemoVendorApplicationMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DemoVendorApplicationMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IVendorService _vendorService;

        public HomeController(ILogger<HomeController> logger, IVendorService vendorService)
        {
            _logger = logger;
            _vendorService = vendorService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _vendorService.GetAllVendors();

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
