using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Dtos;

namespace App.Domain.Core.BaseData.Contacts.Service
{
    public interface IStatesService
    {
        Task set(StateDto stateDto);
        Task<List<StateDto>> GetAll();
        Task Update(StateDto dto);
        Task Delete(int Id);
    }
}
