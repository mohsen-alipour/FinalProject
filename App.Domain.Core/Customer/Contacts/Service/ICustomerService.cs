using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Dtos;

namespace App.Domain.Core.Customer.Contacts.Service
{
    public interface ICustomerService
    {
        Task set(CustomerDto customerDto);
        Task<List<CustomerDto>> GetAll();
        Task<CustomerDto> Get(int codemeli);
        Task Update(CustomerDto customerDto);
        Task Delete(int codemeli);
    }
}
