using DemoVendorApplicationAPI.DataAccess.DB;
using DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;
using DemoVendorApplicationDLL.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoVendorApplicationAPI.DataAccess.Repository
{
    public class VendorRepository : IVendorRepository
    {
        public VendorDBContext _db { get; set; }
        public VendorRepository(VendorDBContext context)
        {
            this._db = context;
        }
        public async Task<Vendor> Create(Vendor entity)
        {
            await _db.Vendors.AddAsync(entity);

            await _db.SaveChangesAsync();

            return await _db.Vendors.Where(m => m.Email == entity.Email).FirstAsync();
        }

        public Task<Vendor> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task<Vendor> GetById(Guid id)
        {
            return await _db.Vendors.Where(m => m.Id == id).FirstAsync();
        }

        public async Task<List<Vendor>> GetList()
        {
            return await _db.Vendors.ToListAsync();

        }

        public async Task<List<Vendor>> GetList(Guid id)
        {
            return await _db.Vendors.Where(m => m.Id == id).ToListAsync();
        }

        public Task<Vendor> Update(Vendor entity)
        {
            throw new NotImplementedException();
        }
    }
}
