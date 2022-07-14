using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Entity;

namespace App.Domain.Core.Expert.Entity
{
    public class ExpertCategurySKill
    {
        public int ID { get; set; }
        public int ExpertId { get; set; }
        public Experts Expert { get; set; }
        public int CateguryServiceID { get; set; }
        public CategurySKill CateguryService { get; set; }
        

      
    }
}
