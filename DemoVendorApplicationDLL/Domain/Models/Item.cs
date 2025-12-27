using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVendorApplicationDLL.Domain.Models;

public class Item : BaseModel
{
    public Guid VendorId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public int Cost { get; set; }
    public int Stock { get; set; }
}
