using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.BaseData.Dtos
{
    public class CategurySKillDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ParentId { get; set; }
        public byte[] picture { get; set; }
        public string Description { get; set; }
    }
}
