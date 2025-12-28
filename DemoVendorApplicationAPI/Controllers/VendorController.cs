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

    [HttpGet("{id}")]
    public async Task<Vendor> Index(Guid id)
    {
        return await _vendorRepository.GetById(id);
    }

    [HttpPost]
    public async Task<Vendor> PostAsync(Vendor entity)
    {
        return await _vendorRepository.Create(entity);
    }
}
