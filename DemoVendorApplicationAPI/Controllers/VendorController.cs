using DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;
using DemoVendorApplicationDLL.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoVendorApplicationAPI.Controllers;


[Route("api/[controller]")]
[ApiController]
public class VendorController : Controller
{
    public IVendorRepository _vendorRepository { get; set; }
    public VendorController(IVendorRepository vendorRepository)
    {
        this._vendorRepository = vendorRepository;
    }

    [HttpGet]
    public async Task<List<Vendor>> Index()
    {
        return await _vendorRepository.GetList();
    }
}
