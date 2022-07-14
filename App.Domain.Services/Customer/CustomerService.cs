using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.Service;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Contacts.Repositories;
namespace App.Domain.Services.Customer
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task set(CustomerDto customerDto)
        {
           await _customerRepository.Add(customerDto);
        }
        public async Task<List<CustomerDto>> GetAll()
        {
           return await _customerRepository.GetAll();
        }
        public async Task<CustomerDto> Get(int codemeli)
        {
            return await _customerRepository.Get(codemeli);
        }
        public async Task Delete(int codemeli)
        {
            await _customerRepository.Delete(codemeli);
        }

        public async Task Update(CustomerDto customerDto)
        {
            await _customerRepository.Update(customerDto);
        }
    }
}
