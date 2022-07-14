using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Contacts.AppService;
using App.Domain.Core.Customer.Dtos;
using App.Domain.Core.Customer.Contacts.Service;

namespace App.Domain.AppServices.Customer
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;

        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task set(CustomerDto customerDto)
        {
           await _customerService.set(customerDto);
        }
        public async Task<List<CustomerDto>> GetAll()
        {
           return await _customerService.GetAll();
        }
        public async Task<CustomerDto> Get(int codemeli)
        {
           return await _customerService.Get(codemeli);
        }
        public async Task Update(CustomerDto dto)
        {
            await _customerService.Update(dto);
        }

        public async Task Delete(int codemeli)
        {
            await _customerService.Delete(codemeli);
        }

      
    }
}
