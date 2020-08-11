using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Strategy
{
    public interface IStrategy
    {
        bool Condition(int value);
    }
}
