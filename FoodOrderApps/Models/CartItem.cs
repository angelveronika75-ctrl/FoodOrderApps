using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrderApps.Models
{
    internal class CartItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
        public double Total => Item.Price * Quantity;
    }
}
