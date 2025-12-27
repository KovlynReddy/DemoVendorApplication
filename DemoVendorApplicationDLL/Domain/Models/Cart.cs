using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVendorApplicationDLL.Domain.Models;

public class Cart : BaseModel
{
    public Guid ItemId { get; set; }
    public Guid CustomerId { get; set; }
    public bool IsCancelled { get; set; }
    public int Quantity { get; set; }
    public int Subtotal { get; set; }
}
