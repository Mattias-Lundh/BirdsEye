using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsEye.Domain.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string ItemCatagory { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public List<InventoryItemStatus> InventoryItemStatuses { get; set; }
        public List<ItemNote> ItemNotes { get; set; }
    }
}
