using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Bridge
{
    public class ImplementationA : IImplementation
    {
        public string Operation()
        {
            return "A";
        }
    }
}
