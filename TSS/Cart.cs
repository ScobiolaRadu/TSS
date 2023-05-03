using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSS
{
    public class Cart
    {
        private List<Item> _items;
        public Cart(List<Item> items)
        {
            _items = items;
        }

        public double Total => _items.Aggregate(0, (double sum, Item item) => sum + item.CalculatePrice(item));
    }
}
