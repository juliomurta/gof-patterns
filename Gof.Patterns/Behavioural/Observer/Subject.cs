using Gof.Patterns.Behavioural.Observer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Observer
{
    public enum State
    {
        Active,
        Inactive
    }

    public class Subject : ISubject
    {
        public State State { get; set; } = State.Active;

        private IList<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(this);
            }
        }

        public void ChangeStates()
        {
            this.State = State.Inactive;
            this.Notify();
        }
    }
}
