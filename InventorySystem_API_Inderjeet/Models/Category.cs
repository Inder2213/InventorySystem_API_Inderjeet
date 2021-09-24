using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem_API_Inderjeet.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public List<StockMaintain> StockMaintains { get; set; }
    }
}
