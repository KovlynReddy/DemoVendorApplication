using DemoVendorApplicationDLL.Domain.Models;
using DemoVendorApplicationMVC.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DemoVendorApplicationMVC.Controllers;

public class VendorController : Controller
{
    public IVendorService _vendorService { get; set; }
    public VendorController(IVendorService vendorService)
    {
            this._vendorService = vendorService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        return View(await _vendorService.GetAllVendors());
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Vendor entity)
    {
        return View(await _vendorService.PostVendor(entity));
    }
}
