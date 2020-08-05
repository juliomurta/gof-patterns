using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Bridge
{
    public class Abstraction
    {
        protected IImplementation implementation;

        public Abstraction(IImplementation implementation)
        {
            this.implementation = implementation;
        }

        public virtual string Operation()
        {
            return $"Abstract: { this.implementation.Operation() }";
        }
    }
}
