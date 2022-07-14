using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Expert.Contacts.Repositories;
using App.Domain.Core.Expert.Dtos;
using App.Infrastructures.Database.SqlServer;
using Microsoft.EntityFrameworkCore;
using App.Domain.Core.Expert.Entity;

namespace App.Infrastructures.Database.Repositoy.Ef.Expert
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly AppDbContext _context;

        public ExpertRepository(AppDbContext Context)
        {
            _context = Context;
        }
        public async Task Add(ExpertDto ExpertDto)
        {
            Experts expert = new Experts()
            {
                Name = ExpertDto.Name,
                Family = ExpertDto.Family,
                dateOfBirth = ExpertDto.dateOfBirth,
                CodeMeli = ExpertDto.CodeMeli,
                Mobile = ExpertDto.Mobile,
                city = ExpertDto.city,
                Address = ExpertDto.Address,
                picture = ExpertDto.picture,

            };
            _context.Experts.Add(expert);
            await _context.SaveChangesAsync();
        }
        public async Task<List<ExpertDto>> GetAll()
        {
            return await _context.Experts.Select(p => new ExpertDto()
            {
                Name = p.Name,
                Family = p.Family,
                CodeMeli = p.CodeMeli,
                dateOfBirth = p.dateOfBirth,
                city = p.city,
                Mobile = p.Mobile,
                Address = p.Address,
                picture = p.picture,
            }).ToListAsync();
        }
        public async Task<ExpertDto> Get(int codemeli)
        {
            return await _context.Experts.Where(p => p.CodeMeli == codemeli).Select(p => new ExpertDto()
            {
                Name = p.Name,
                Family = p.Family,
                CodeMeli = p.CodeMeli,
                dateOfBirth = p.dateOfBirth,
                city = p.city,
                Mobile = p.Mobile,
                Address = p.Address,
                picture = p.picture,
                ID = p.ID,
            }).SingleAsync();
        }
        public async Task Update(ExpertDto ExpertDto)
        {
            var record = await _context.Experts.Where(p => p.CodeMeli == ExpertDto.CodeMeli).SingleOrDefaultAsync();
            record.Name = ExpertDto.Name;
            record.Family = ExpertDto.Family;
            record.dateOfBirth = ExpertDto.dateOfBirth;
            record.city = ExpertDto.city;
            record.Mobile = ExpertDto.Mobile;
            record.Address = ExpertDto.Address;
            record.picture = ExpertDto.picture;
            _context.SaveChangesAsync();

        }
        public async Task Delete(int codemeli)
        {
            var record = await _context.Experts.Where(p => p.CodeMeli == codemeli).SingleOrDefaultAsync();
            _context.Experts.Remove(record);
            _context.SaveChangesAsync();
        }

    }
}
