using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventorySystem_API_Inderjeet.Models
{
    public class StockMaintain
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int SoldItems { get; set; }
        public int LeftItems { get; set; }
    }
}
