using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.State
{
    public class MyLamp
    {
        public LampState State { get; set; }

        public MyLamp(LampState state)
        {
            this.State = state;
        }

        public void ChangeState()
        {
            this.State.Handle(this);
        }
    }
}
