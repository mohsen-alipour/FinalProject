using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Customer.Dtos
{
    public class CustomerCategurySKillDto
    {
        public int ID { get; set; }
        public int CustomersID { get; set; }       
        public int CateguryServiceID { get; set; }     
        public DateTime OrderDate { get; set; }
        public string Description { get; set; }
        public string Sparetel { get; set; }
        public string TargetAddress { get; set; }
    }
}
