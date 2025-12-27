using DemoVendorApplicationDLL.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoVendorApplicationAPI.DataAccess.DB;

public class VendorDBContext : DbContext
{
    public VendorDBContext(DbContextOptions<VendorDBContext> options)
    : base(options)
    {
    }

    public DbSet<Vendor> Vendors { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Cart> Carts { get; set; }
}
