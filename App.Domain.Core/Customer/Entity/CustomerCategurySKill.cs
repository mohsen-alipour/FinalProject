using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Entity;

namespace App.Domain.Core.Customer.Entity
{
    public class CustomerCategurySKill
    {
        public int ID { get; set; }
        public int CustomersID { get; set; }
        public Customers Customers { get; set; }
        public int CateguryServiceID { get; set; }
        public CategurySKill CateguryService { get; set; }
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public string Sparetel { get; set; }
        public string TargetAddress { get; set; }

    }
}


