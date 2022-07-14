using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Dtos;

namespace App.Domain.Core.BaseData.Contacts.AppService
{
    public interface ICategurySKillAppService
    {
        Task set(CategurySKillDto customerDto);
        Task<List<CategurySKillDto>> GetAll();
        Task<CategurySKillDto> Get(string name);
        Task Update(CategurySKillDto dto);
        Task Delete(int Id);
    }
}
