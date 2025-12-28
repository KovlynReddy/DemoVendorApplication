using DemoVendorApplicationDLL.Domain.Models;
using DemoVendorApplicationMVC.Interfaces;
using DemoVendorApplicationMVC.Models.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DemoVendorApplicationMVC.Controllers;

public class VendorController : Controller
{
    public IVendorService _vendorService { get; set; }
    public IMediator _mediator { get; set; }
    public VendorController(IVendorService vendorService, IMediator mediator)
    {
        this._vendorService = vendorService;
        this._mediator = mediator;
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
    public async Task<IActionResult> Create(CreateVendorViewModel entity)
    {
        await _mediator.Send(entity);
        return RedirectToAction("Index");
    }
}
