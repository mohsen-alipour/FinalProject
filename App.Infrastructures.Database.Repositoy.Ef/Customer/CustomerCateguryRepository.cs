using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.Repositories;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Entity;
using App.Infrastructures.Database.SqlServer;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructures.Database.Repositoy.Ef.Customer
{
    public class CustomerCateguryRepository : ICustomerCategurySkillRepository
    {
        private readonly AppDbContext _context;

        public CustomerCateguryRepository(AppDbContext Context)
        {
            _context = Context;
        }
        public async Task Add(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            CustomerCategurySKill Ordercustomer=new CustomerCategurySKill()
            {
                CustomersID=CustomerCategurySKillDto.CustomersID,
                CateguryServiceID=CustomerCategurySKillDto.CateguryServiceID,
                OrderDate=CustomerCategurySKillDto.OrderDate,
                Sparetel=CustomerCategurySKillDto.Sparetel,
                TargetAddress=CustomerCategurySKillDto.TargetAddress,
                Description=CustomerCategurySKillDto.Description,
            };
            _context.CustomerCategurySKill.Add(Ordercustomer);
            _context.SaveChangesAsync();
        }
        public async Task<List<CustomerCategurySKillDto>> GetAll()
        {
          return await  _context.CustomerCategurySKill.Select(p => new CustomerCategurySKillDto()
            {
                CustomersID = p.CustomersID,
                CateguryServiceID = p.CustomersID,
                OrderDate=p.OrderDate,
                Sparetel = p.Sparetel,
                TargetAddress=p.TargetAddress,
                Description = p.Description,
                
            }).ToListAsync();
        }
        public async Task<List<CustomerCategurySKillDto>> Get(int CustomersID)
        {
            return await _context.CustomerCategurySKill.Where(p => p.CustomersID == CustomersID).Select(p => new CustomerCategurySKillDto()
            {
                CustomersID = p.CustomersID,
                CateguryServiceID = p.CustomersID,
                OrderDate = p.OrderDate,
                Sparetel = p.Sparetel,
                TargetAddress = p.TargetAddress,
                Description = p.Description,
            }).ToListAsync();       
        }

        public async Task Update(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            var order = await _context.CustomerCategurySKill.Where(p => p.ID == CustomerCategurySKillDto.ID).SingleAsync();
            order.CateguryServiceID=CustomerCategurySKillDto.CateguryServiceID;
            order.OrderDate=CustomerCategurySKillDto.OrderDate;
            order.Sparetel=CustomerCategurySKillDto.Sparetel;
            order.TargetAddress=CustomerCategurySKillDto.TargetAddress;
            order.Description=CustomerCategurySKillDto.Description;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var order = await _context.CustomerCategurySKill.Where(p => p.ID == id).SingleAsync();
            _context.CustomerCategurySKill.Remove(order);
            await _context.SaveChangesAsync();
        }

      
    }
}
