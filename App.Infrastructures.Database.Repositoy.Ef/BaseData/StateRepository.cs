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
    public class StateRepository : IStatesRepository
    {
        private readonly AppDbContext _context;

        public StateRepository(AppDbContext Context)
        {
            _context = Context;
        }
        public async Task Add(StateDto StateDto)
        {
            States states = new States()
            {
                Name = StateDto.Name,
                CreationDate = DateTime.Now,
            };
            _context.States.Add(states);
            await _context.SaveChangesAsync();
        }
        public async Task<List<StateDto>> GetAll()
        {
            return await _context.States.Select(P => new StateDto()
            {
                Name = P.Name,
                CreationDate = P.CreationDate,
                ID = P.ID,
            }).ToListAsync();

        }

        public async Task Update(StateDto StateDto)
        {
            var state = await _context.States.Where(p => p.ID == StateDto.ID).SingleAsync();
            state.Name = StateDto.Name;
            state.CreationDate = StateDto.CreationDate;        
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var state = await _context.States.Where(p => p.ID == id).SingleAsync();
            _context.States.Remove(state);
            await _context.SaveChangesAsync();
        }
    }
}
