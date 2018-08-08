using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class InventoryToInventoryStatus
    {
        public int InventoryId { get; set; }
        public Inventory Inventory { get; set; }
        public int ItemStatusId { get; set; }
        public InventoryStatus InventoryStatus { get; set; }
    }
}
