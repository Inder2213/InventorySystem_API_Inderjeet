using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem_API_Inderjeet.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }

        public List<StockMaintain> StockMaintains { get; set; }
    }
}
