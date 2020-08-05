using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Decorator
{
    public class Cappuccino : CoffeeDecorator
    {
        public Cappuccino(Beverage beverage) : base(beverage)
        {

        }

        public override string Description()
        {
            return $"{ base.Description() } Cappuccino";
        }
    }
}
