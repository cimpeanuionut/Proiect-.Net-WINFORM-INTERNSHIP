using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ItemModel
    {
        public int itemId { get; set; }
        public string itemName { get; set; }
        public string itemCode { get; set; }
        public string measuringUnitName { get; set; }
        public string itemDescription { get; set; }

        public ItemModel()
        {

        }

    }
}
