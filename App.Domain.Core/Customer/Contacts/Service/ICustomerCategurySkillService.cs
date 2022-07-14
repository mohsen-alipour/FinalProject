using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Dtos;

namespace App.Domain.Core.Customer.Contacts.Service
{
    public interface ICustomerCategurySkillService
    {
        Task set(CustomerCategurySKillDto CustomerCategurySKillDto);
        Task<List<CustomerCategurySKillDto>> GetAll();
        Task<List<CustomerCategurySKillDto>> Get(int customerid);
        Task Update(CustomerCategurySKillDto CustomerCategurySKillDto);
        Task Delete(int id);
    }
}
