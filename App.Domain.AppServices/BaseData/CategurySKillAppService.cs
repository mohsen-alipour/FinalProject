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
    public class CategurySKillAppService : ICategurySKillAppService
    {
        private readonly ICategurySKillService _categurySKillService;

        public CategurySKillAppService(ICategurySKillService categurySKillService)
        {
            _categurySKillService = categurySKillService;
        }
      
        public async Task set(CategurySKillDto CategurySKillDto)
        {
            await _categurySKillService.set(CategurySKillDto);
        }
        public async Task<List<CategurySKillDto>> GetAll()
        {
          return  await _categurySKillService.GetAll();
        }
        public async Task<CategurySKillDto> Get(string name)
        {
            return await _categurySKillService.Get(name);
        }
        public async Task Update(CategurySKillDto CategurySKillDto)
        {
            await _categurySKillService.Update(CategurySKillDto);
        }
        public async Task Delete(int Id)
        {
            await _categurySKillService.Delete(Id);
        }
      
    }
}
