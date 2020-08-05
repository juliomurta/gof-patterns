using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Bridge
{
    public class ImplementationB : IImplementation
    {
        public string Operation()
        {
            return "B";
        }
    }
}
