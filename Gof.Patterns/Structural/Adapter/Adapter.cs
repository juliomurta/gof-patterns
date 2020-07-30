using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Adapter
{
    public class Adapter : ITarget
    {
        Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is { this.adaptee.GetSpecificRequest() }";
        }
    }
}
