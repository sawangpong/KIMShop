using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIM.models.Warehouse.Inventory
{
    public class ItemOnHand
    {
        public string ItemNo { get; set; }
        public string ItemName { get; set; }

        public string Unit { get; set; }
        public decimal UnitCost { get; set; }
        public decimal OnHand { get; set; }
        public decimal Available { get; set; }
    }
}
