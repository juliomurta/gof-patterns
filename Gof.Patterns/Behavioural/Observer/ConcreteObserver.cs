using Gof.Patterns.Behavioural.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Observer
{
    public class ConcreteObserver : IObserver
    {
        public bool IsActive { get; private set; } = true;

        public void Update(ISubject subject)
        {
            if ((subject as Subject).State == State.Inactive)
            {
                this.IsActive = false;
            }
        }
    }
}
