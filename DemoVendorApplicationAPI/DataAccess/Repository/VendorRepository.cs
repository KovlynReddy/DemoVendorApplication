using DemoVendorApplicationAPI.DataAccess.DB;
using DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;
using DemoVendorApplicationDLL.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoVendorApplicationAPI.DataAccess.Repository
{
    public class VendorRepository : IVendorRepository
    {
        //public VendorDBContext _db { get; set; }        
        //public VendorRepository(VendorDBContext context)
        //{
        //    this._db = context;
        //}

        public VendorRepository()
        {
            
        }

        public Task<Vendor> Create(Vendor entity)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> Delete(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<Vendor> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vendor>> GetList()
        {
            //return await _db.Vendors.ToListAsync();
            return new List<Vendor>() { 
            new Vendor(){ 
            Email = "testEmail",
            DisplayName = "Testname"
            },  new Vendor(){
            Email = "testEmail2",
            DisplayName = "Testname2"
            }  };

        }

        public async Task<List<Vendor>> GetList(Guid id)
        {
            //return await _db.Vendors.Where(m => m.Id == id).ToListAsync();
            throw new NotImplementedException();
        }

        public Task<Vendor> Update(Vendor entity)
        {
            throw new NotImplementedException();
        }
    }
}
