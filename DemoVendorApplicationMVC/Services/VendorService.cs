using DemoVendorApplicationDLL.Constants;
using DemoVendorApplicationDLL.Domain.Models;
using DemoVendorApplicationMVC.DataAccess.Client;
using DemoVendorApplicationMVC.Interfaces;

namespace DemoVendorApplicationMVC.Services;

public class VendorService : IVendorService
{
    public VendorClient _client { get; set; }
    public VendorService()
    {
        this._client = new VendorClient(URLConstants.Vendor);
    }

    public async Task<List<Vendor>> GetAllVendors()
    {
        return await _client.GetList();
    }

    public async Task<Vendor> PostVendor(Vendor entity)
    {
        return await _client.PostJsonAsync(entity);
    }
}
