using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.State
{
    public class LampOn : LampState
    {
        public override void Handle(MyLamp lamp)
        {
            lamp.State = new LampOff();
        }
    }
}
