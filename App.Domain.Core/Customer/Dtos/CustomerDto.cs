using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string city { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int CodeMeli { get; set; }
        public string Password { get; set; }

    }
}
