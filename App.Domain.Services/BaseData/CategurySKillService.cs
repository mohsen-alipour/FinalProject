using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Contacts.Service;
using App.Domain.Core.BaseData.Dtos;

namespace App.Domain.Services.BaseData
{
    public class CategurySKillService : ICategurySKillService
    {
        public CategurySKillService()
        {

        }
        public Task set(CategurySKillDto customerDto)
        {
            throw new NotImplementedException();
        }
        public Task<List<CategurySKillDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategurySKillDto> Get(string name)
        {
            throw new NotImplementedException();
        }
        public Task Update(CategurySKillDto dto)
        {
            throw new NotImplementedException();
        }
        public Task Delete(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
