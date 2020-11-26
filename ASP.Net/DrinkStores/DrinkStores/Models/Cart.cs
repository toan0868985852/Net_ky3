using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public void AddItem(Drink drink, int quantity)
        {
            CartLine line = Lines
                .Where(p => p.Drink.DrinkID == drink.DrinkID)
                .FirstOrDefault();
            if(line == null)
            {
                Lines.Add(new CartLine
                {
                    Drink = drink,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Drink drink)
            => Lines.RemoveAll(l => l.Drink.DrinkID == drink.DrinkID);

        public decimal ComputeTotalValue()
            => Lines.Sum(e => e.Drink.Price * e.Quantity);

        public void Clear()
            => Lines.Clear();
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Drink Drink { get; set; }
        public int Quantity { get; set; }
    }
}
