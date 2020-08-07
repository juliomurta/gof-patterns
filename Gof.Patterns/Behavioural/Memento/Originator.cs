using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.Memento
{
    public class Originator
    {
        private string state;

        public Originator(string state)
        {
            this.state = state;
        }

        public void DoSomething()
        {
            this.state = this.GenerateRandomString(30);
        }

        private string GenerateRandomString(int length = 10)
        {
            string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = string.Empty;

            while (length > 0)
            {
                result += allowedSymbols[new Random().Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);
                length--;
            }

            return result;
        }

        public IMemento Save()
        {
            return new ConcreteMemento(this.state);
        }

        public void Restore(IMemento memento)
        {
            this.state = memento.GetState();
        }
    }

    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }

    public class ConcreteMemento : IMemento
    {
        private string state;
        private DateTime date;

        public ConcreteMemento(string state)
        {
            this.state = state;
            this.date = DateTime.Now;
        }

        public DateTime GetDate()
        {
            return this.date;
        }

        public string GetName()
        {
            return $"{this.date} / ({this.state.Substring(0, 9)})...";
        }

        public string GetState()
        {
            return this.state;
        }
    }

    public class Caretaker
    {
        private IList<IMemento> mementos = new List<IMemento>();
        private Originator originator = null;

        public Caretaker(Originator originator)
        {
            this.originator = originator;
        }

        public IMemento Backup()
        {
            var x = this.originator.Save();
            this.mementos.Add(x);
            return x;
        }

        public IMemento Undo()
        {
            if (this.mementos.Count == 0)
            {
                return null;
            }

            var memento = this.mementos.Last();
            this.mementos.Remove(memento);

            try
            {
                this.originator.Restore(memento);
                return this.mementos.Last();
            }
            catch (Exception)
            {
                this.Undo();
                return null;
            }
        }
    }
}
