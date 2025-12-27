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
    public async Task<List<Vendor>> Index()
    {
        return await _vendorService.GetAllVendors();
    }
}
