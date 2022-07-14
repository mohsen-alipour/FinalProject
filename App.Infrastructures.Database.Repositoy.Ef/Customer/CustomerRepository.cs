using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.Repositories;
using App.Domain.Core.Customer.Dtos;
using App.Infrastructures.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using App.Domain.Core.Customer.Entity;
namespace App.Infrastructures.Database.Repositoy.Ef.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext Context)
        {
            _context = Context;
        }

        public async Task Add(CustomerDto CustomerDto)
        {
           Customers custom=new Customers()
           {
               Name = CustomerDto.Name,
               Family=CustomerDto.Family,
               CodeMeli = CustomerDto.CodeMeli,
               Mobile = CustomerDto.Mobile,
               Address = CustomerDto.Address,
               city=CustomerDto.city,
           };
            _context.Customers.Add(custom);
            _context.SaveChangesAsync();
        }
        public async Task<List<CustomerDto>> GetAll()
        {
           return await _context.Customers.Select(p=>new CustomerDto()
           {
               Name = p.Name,
               Family = p.Family,
               CodeMeli = p.CodeMeli,
               Mobile = p.Mobile,
               Address = p.Address,
               city=p.city,
               
           }).ToListAsync();

        }
        public async Task<CustomerDto> Get(int codemeli)
        {
            var record=await _context.Customers.Where(p=>p.CodeMeli==codemeli).Select(p=>new CustomerDto()
                {
                Name = p.Name,
                Family = p.Family,
                CodeMeli = p.CodeMeli,
                Mobile = p.Mobile,
                Address = p.Address,
                city = p.city,
                Id=p.ID,
            }).SingleOrDefaultAsync();
            return record;
        }
        public async Task Update(CustomerDto CustomerDto)
        {
            var custom = await _context.Customers.Where(p => p.CodeMeli == CustomerDto.CodeMeli).SingleAsync();
            custom.Name = CustomerDto.Name;
            custom.Family = CustomerDto.Family;
            custom.CodeMeli = CustomerDto.CodeMeli;
            custom.Mobile = CustomerDto.Mobile;
            custom.Address = CustomerDto.Address;
            custom.city = CustomerDto.city;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int codemeli)
        {
            var custom =await _context.Customers.Where(p => p.CodeMeli == codemeli).SingleAsync();
            _context.Customers.Remove(custom);        
            await _context.SaveChangesAsync();
        }
 
      
    }
}
