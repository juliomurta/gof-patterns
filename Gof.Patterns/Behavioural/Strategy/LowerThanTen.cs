using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Strategy
{
    public class LowerThanTen : IStrategy
    {
        public bool Condition(int value)
        {
            return value < 10;
        }
    }
}
