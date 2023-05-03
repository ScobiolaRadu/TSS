using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS
{
    public class Item
    {
        private double Price;
        private double Quantity;

        public Item(int quantity, double price)
        {
            Price = price;
            Quantity = quantity;
        }

        public double CalculatePrice(Item item)
        {
            return item.Quantity * item.Price;
        }
    }
}
