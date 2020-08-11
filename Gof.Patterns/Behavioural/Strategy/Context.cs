using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Strategy
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int CheckCondition(int value)
        {
            if (this.strategy.Condition(value))
            {
                return 1000;
            }

            return 0;
        }
    }
}
