using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.BaseData.Entity;

namespace App.Domain.Core.Expert.Entity
{
    public class Experts
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string city { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public int CodeMeli { get; set; }
        public byte[] picture { get; set; }
        public DateTime dateOfBirth { get; set; }
        //public List<CateguryService> CateguryServices { get; set; }

    }
}
