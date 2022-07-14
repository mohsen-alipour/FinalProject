using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.AppService;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Contacts.Service;

namespace App.Domain.AppServices.BaseData
{
    public class CustomerCategurySkillAppService : ICustomerCategurySKillAppService
    {
        private readonly ICustomerCategurySkillService _customerCategurySkillService;

        public CustomerCategurySkillAppService(ICustomerCategurySkillService customerCategurySkillService)
        {
            _customerCategurySkillService = customerCategurySkillService;
        }
        public async Task set(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            await _customerCategurySkillService.set(CustomerCategurySKillDto);
        }
        public async Task<List<CustomerCategurySKillDto>> GetAll()
        {
            return await _customerCategurySkillService.GetAll();
        }
        public async Task<List<CustomerCategurySKillDto>> Get(int Customerid)
        {
            return await _customerCategurySkillService.Get(Customerid);
        }   
        public async Task Update(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            await _customerCategurySkillService.Update(CustomerCategurySKillDto);
        }
        public async Task Delete(int id)
        {
            await _customerCategurySkillService.Delete(id);
        }
    }
}
