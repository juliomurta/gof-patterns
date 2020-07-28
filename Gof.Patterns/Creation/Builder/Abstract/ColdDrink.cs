using Gof.Patterns.Creation.Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Builder.Abstract
{
    public abstract class ColdDrink : Item
    {
        public Packing Packing => new Bottle();

        public abstract string Name();

        public abstract decimal Price();
    }
}
