using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Proxy
{
    public class RealSubject : ISubject
    {
        public string Operation()
        {
            return "ok";
        }
    }
}
