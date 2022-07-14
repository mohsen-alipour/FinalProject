using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Dtos;

namespace App.Domain.Core.Customer.Contacts.AppService
{
    public interface ICustomerAppService
    {
        Task set(CustomerDto customerDto);
        Task<List<CustomerDto>> GetAll();
        Task<CustomerDto> Get(int customerid);
        Task Update(CustomerDto dto);
        Task Delete(int codemeli);

    }
}
