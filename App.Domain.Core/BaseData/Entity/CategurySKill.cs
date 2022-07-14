using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Entity;
using App.Domain.Core.Expert.Entity;

namespace App.Domain.Core.BaseData.Entity
{
    public class CategurySKill
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
        public byte[] picture { get; set; }
        public string Description { get; set; }


        //public ICollection<CustomerCateguryService> CustomerCateguryService { get; set; }
        //public List<Customers> customers { get; set; }
        //public List<Experts> Experts { get; set; }


    }
}
