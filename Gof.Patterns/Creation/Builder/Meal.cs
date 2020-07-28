using Gof.Patterns.Creation.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Builder
{
    public class Meal
    {
        private IList<Item> items = new List<Item>();

        public void Add(Item item)
        {
            this.items.Add(item);
        }

        public decimal Cost()
        {
            return this.items.Sum(x => x.Price());
        }

        public IList<Item> GetItems()
        {
            return this.items;
        }
    }
}
