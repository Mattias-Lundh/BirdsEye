using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class JobInventory
    {
        public int JobsId { get; set; }
        public Jobs Jobs { get; set; }
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
    }
}
