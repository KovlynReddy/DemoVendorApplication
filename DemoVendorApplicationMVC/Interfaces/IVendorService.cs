using DemoVendorApplicationDLL.Domain.Models;

namespace DemoVendorApplicationMVC.Interfaces;

public interface IVendorService
{
    public Task<List<Vendor>> GetAllVendors();
    public Task<Vendor> PostVendor(Vendor entity);
}
