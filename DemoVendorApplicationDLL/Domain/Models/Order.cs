namespace DemoVendorApplicationDLL.Domain.Models;

public class Order : BaseModel
{
    public Guid CartId { get; set; }
    public Guid CustomerId { get; set; }
    public DateTime DatePaid { get; set; }
    public bool IsPaid { get; set; }
    public bool IsCancelled { get; set; }
    public int Total { get; set; }
}
