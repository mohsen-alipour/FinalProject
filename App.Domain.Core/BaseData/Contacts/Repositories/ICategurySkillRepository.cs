using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Dtos;

namespace App.Domain.Core.BaseData.Contacts.Repositories
{
    public interface ICategurySkillRepository
    {
        Task Add(CategurySKillDto CategurySKillDto);
        Task<List<CategurySKillDto>> GetAll();
        Task<CategurySKillDto> Get(string name);
        Task Update(CategurySKillDto CategurySKillDto);
        Task Delete(int id);
    }
}
