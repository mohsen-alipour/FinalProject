using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Dtos;
using App.Domain.Core.BaseData.Contacts.Service;
using App.Domain.Core.BaseData.Contacts.Repositories;

namespace App.Domain.Services.BaseData
{
    public class StatesService : IStatesService
    {
        private readonly IStatesRepository _statesRepository;

        public StatesService(IStatesRepository statesRepository)
        {
            _statesRepository = statesRepository;
        }
        public async Task set(StateDto stateDto)
        {
           await _statesRepository.Add(stateDto);
        }
        public async Task<List<StateDto>> GetAll()
        {
           return await _statesRepository.GetAll();    
        }
        public async Task Update(StateDto StateDto)
        {
            await _statesRepository.Update(StateDto);
        }
        public async Task Delete(int Id)
        {
            await _statesRepository.Delete(Id);
        }
 
    }
}
