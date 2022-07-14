using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.Service;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Contacts.Repositories;

namespace App.Domain.Services.BaseData
{
    public class CustomerCategurySkillService : ICustomerCategurySkillService
    {
        private readonly ICustomerCategurySkillRepository _customerCategurySkillRepository;

        public CustomerCategurySkillService(ICustomerCategurySkillRepository customerCategurySkillRepository)
        {
            _customerCategurySkillRepository = customerCategurySkillRepository;
        }
        public async Task set(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            _customerCategurySkillRepository.Add(CustomerCategurySKillDto);
        }
        public async Task<List<CustomerCategurySKillDto>> GetAll()
        {
            return await _customerCategurySkillRepository.GetAll();
        }
      
        public async Task<List<CustomerCategurySKillDto>> Get(int Customerid)
        {
            return await _customerCategurySkillRepository.Get(Customerid);
        }

        public async Task Update(CustomerCategurySKillDto CustomerCategurySKillDto)
        {
            await _customerCategurySkillRepository.Update(CustomerCategurySKillDto);
        }
        public async Task Delete(int id)
        {
            await _customerCategurySkillRepository.Delete(id);
        }
    }
}
