using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Contacts.Repositories;
using App.Domain.Core.BaseData.Dtos;
using App.Infrastructures.Database.SqlServer;
using App.Domain.Core.BaseData.Entity;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructures.Database.Repositoy.Ef.BaseData
{
    public class CategurySKillRepository : ICategurySkillRepository
    {
        private readonly AppDbContext _context;

        public CategurySKillRepository(AppDbContext Context)
        {
            _context = Context;
        }
        public async Task Add(CategurySKillDto CategurySKillDto)
        {
            CategurySKill categury_Skill=new CategurySKill()
            {
                Title = CategurySKillDto.Title,
                ParentId= CategurySKillDto.ParentId,
            };
            _context.CategurySKill.Add(categury_Skill);
            _context.SaveChangesAsync();
        }
        public async Task<List<CategurySKillDto>> GetAll()
        {
            return await _context.CategurySKill.Select(p => new CategurySKillDto()
            {
                ID=p.ID,
                Title=p.Title,
                ParentId=p.ParentId,
                picture=p.picture,
                Description=p.Description,

            }).ToListAsync();
        }
        public async Task<CategurySKillDto> Get(string title)
        {
            var record = await _context.CategurySKill.Where(p => p.Title == title).Select(p => new CategurySKillDto()
            {
                ID = p.ID,
                Title = p.Title,
                ParentId = p.ParentId,
            }).FirstOrDefaultAsync();
            return record;
        }
        public async Task Update(CategurySKillDto CategurySKillDto)
        {
            var Categury_SKill = await _context.CategurySKill.Where(p => p.ID == CategurySKillDto.ID).SingleAsync();
            Categury_SKill.Title=CategurySKillDto.Title;
            Categury_SKill.ParentId=CategurySKillDto.ParentId;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var Categury_SKill = await _context.CategurySKill.Where(p => p.ID == id).SingleAsync();
            _context.CategurySKill.Remove(Categury_SKill);
            await _context.SaveChangesAsync();

        }   
    }
}
