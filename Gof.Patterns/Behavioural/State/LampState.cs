using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.State
{
    public abstract class LampState
    {
        public abstract void Handle(MyLamp lamp);
    }
}
