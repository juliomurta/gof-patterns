using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Decorator
{
    public class CoffeeWithMilk : CoffeeDecorator
    {
        public CoffeeWithMilk(Beverage beverage) : base(beverage)
        {

        }

        public override string Description()
        {
            return $"{ base.Description() } with milk";
        }
    }
}
