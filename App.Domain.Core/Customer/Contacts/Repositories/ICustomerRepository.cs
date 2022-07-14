using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Dtos;


namespace App.Domain.Core.Customer.Contacts.Repositories
{
    public interface ICustomerRepository
    {
        Task Add(CustomerDto dto);
        Task<List<CustomerDto>> GetAll();
        Task<CustomerDto> Get(int codemeli);
        Task Update(CustomerDto dto);
        Task Delete(int codemeli);
       
        
    }
}
