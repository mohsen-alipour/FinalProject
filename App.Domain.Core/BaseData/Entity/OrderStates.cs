using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.Customer.Entity;

namespace App.Domain.Core.BaseData.Entity
{
    public class OrderStates
    {
        public int Id { get; set; }
        public int CustomerCateguryServiceID { get; set; }
        public CustomerCategurySKill CustomerCateguryService { get; set; }

        public States States { get; set; }
        public int StatesID { get; set; }
        public DateTime DateState { get; set; }



    }
}
