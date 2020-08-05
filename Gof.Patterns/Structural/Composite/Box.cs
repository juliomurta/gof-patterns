using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Composite
{
    public class Box : Item
    {
        protected IList<Item> items = new List<Item>();

        public override void Add(Item item)
        {
            this.items.Add(item);
        }

        public override void Remove(Item item)
        {
            this.items.Remove(item);
        }

        public override decimal Sum()
        {
            return this.items.Sum(x => x.Sum());
        }
    }
}
