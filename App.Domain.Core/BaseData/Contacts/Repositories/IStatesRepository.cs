using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Dtos;

namespace App.Domain.Core.BaseData.Contacts.Repositories
{
    public interface IStatesRepository
    {
        Task Add(StateDto StateDto);
        Task<List<StateDto>> GetAll();
        Task Update(StateDto CategurySKillDto);
        Task Delete(int id);
    }
}
