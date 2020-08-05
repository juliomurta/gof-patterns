using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Composite
{
    public abstract class Item
    {
        public abstract decimal Sum();

        public virtual void Add(Item item)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Item item)
        {
            throw new NotImplementedException();
        }

        public virtual bool IsComposite()
        {
            return true;
        }
    }
}
