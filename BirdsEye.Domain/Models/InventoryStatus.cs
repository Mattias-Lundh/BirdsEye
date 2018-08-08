using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class InventoryStatus
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public List<InventoryToInventoryStatus> InventoryToInventoryStatus { get; set; }
    }
}


/*

     1 = normal
     2 = damaged
     3 = missing
     4 = wornpart  

*/