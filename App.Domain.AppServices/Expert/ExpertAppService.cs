using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Expert.Contacts.AppService;
using App.Domain.Core.Expert.Dtos;
using App.Domain.Core.Expert.Contacts.Service;

namespace App.Domain.AppServices.Expert
{
    public class ExpertAppService : IExpertAppService
    {
        private readonly IExpertService _expertService;

        public ExpertAppService(IExpertService expertService)
        {
            _expertService = expertService;
        }
        public async Task set(ExpertDto customerDto)
        {
             await _expertService.set(customerDto);
        }
        public async Task<List<ExpertDto>> GetAll()
        {
            return await _expertService.GetAll();
        }
        public async Task<ExpertDto> Get(int codemeli)
        {
           return await _expertService.Get(codemeli);
        }
         public async Task Update(ExpertDto ExpertDto)
        {
            await _expertService.Update(ExpertDto);
        }
        public async Task Delete(int codemeli)
        {
            await _expertService.Delete(codemeli);
        }

    }      
}
