using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Expert.Dtos;

namespace App.Domain.Core.Expert.Contacts.Service
{
    public interface IExpertService
    {
        Task set(ExpertDto customerDto);
        Task<List<ExpertDto>> GetAll();
        Task<ExpertDto> Get(int codemeli);
        Task Update(ExpertDto ExpertDto);
        Task Delete(int codemeli);

    }
}
