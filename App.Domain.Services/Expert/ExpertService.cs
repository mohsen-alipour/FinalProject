using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Expert.Contacts.Service;
using App.Domain.Core.Expert.Dtos;
using App.Domain.Core.Expert.Contacts.Repositories;


namespace App.Domain.Services.Expert
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRepository;

        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRepository = expertRepository;
        }
        public async Task set(ExpertDto customerDto)
        {
            await _expertRepository.Add(customerDto);
        }
        public async Task<List<ExpertDto>> GetAll()
        {
            return await _expertRepository.GetAll();
        }

        public async Task<ExpertDto> Get(int codemeli)
        {
            return await _expertRepository.Get(codemeli);
        }
        public async Task Update(ExpertDto ExpertDto)
        {
            await _expertRepository.Update(ExpertDto);
        }
        public async Task Delete(int codemeli)
        {
            await _expertRepository.Delete(codemeli);
        }

    }
}
