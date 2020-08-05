using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Decorator
{
    public abstract class CoffeeDecorator : Beverage
    {
        protected Beverage beverage;

        public CoffeeDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public void SetBeverage(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description()
        {
            if (this.beverage != null)
            {
                return $"I'm {this.beverage.Description()}";
            }
            else
            {
                return "I'm a Coffe";
            }
        }
    }
}
