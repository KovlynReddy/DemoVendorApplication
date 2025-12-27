using DemoVendorApplicationAPI.DataAccess.DB;
using DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;
using DemoVendorApplicationDLL.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoVendorApplicationAPI.DataAccess.Repository;

public class ItemRepository : IItemRepository
{
    public VendorDBContext _db { get; set; }
    public ItemRepository(VendorDBContext context)
    {
        this._db = context;
    }
    public Task<Item> Create(Item entity)
    {
        throw new NotImplementedException();
    }

    public Task<Item> Delete(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Task<Item> GetById(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Item>> GetList()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Item>> GetList(Guid id)
    {
        return await _db.Items.Where(m => m.VendorId == id).ToListAsync();
    }

    public Task<Item> Update(Item entity)
    {
        throw new NotImplementedException();
    }
}
