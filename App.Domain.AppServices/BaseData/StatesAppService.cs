using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Contacts.AppService;
using App.Domain.Core.BaseData.Dtos;
using App.Domain.Core.BaseData.Contacts.Service;
namespace App.Domain.AppServices.BaseData
{
    public class StatesAppService : IStatesAppService
    {
        private readonly IStatesService _statesService;

        public StatesAppService(IStatesService statesService)
        {
            _statesService = statesService;
        }
        public async Task set(StateDto stateDto)
        {
            await _statesService.set(stateDto);
        }
        public async Task<List<StateDto>> GetAll()
        {
           return await _statesService.GetAll();
        }
        public async Task Update(StateDto StateDto)
        {
            await _statesService.Update(StateDto);
        }

        public async Task Delete(int Id)
        {
            await _statesService.Delete(Id);
        }
       
    }
}
