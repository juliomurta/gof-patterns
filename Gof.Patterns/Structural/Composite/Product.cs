using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Composite
{
    public class Product : Item
    {
        public override decimal Sum()
        {
            return 10;
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
