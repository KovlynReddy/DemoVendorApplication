using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVendorApplicationDLL.Domain.Models;

public class Vendor : BaseModel
{
    public string TradingName { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime LastSeen { get; set; }
}
