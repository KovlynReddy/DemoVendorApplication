using DemoVendorApplicationDLL.Domain.Models;

namespace DemoVendorApplicationMVC.DataAccess.Client;

public class VendorClient: BaseClient<Vendor>
{

    public VendorClient(string Url) : base(Url)
    {
            
    }
}
