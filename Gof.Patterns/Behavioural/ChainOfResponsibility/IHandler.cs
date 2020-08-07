using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Behavioural.ChainOfResponsibility
{
    public enum NumberEnum
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4
    }

    public interface IHandler
    {
        IHandler Next(IHandler handler);

        object Handler(object request);
    }

    public abstract class AbstractHandler : IHandler
    {
        private IHandler handler;

        public IHandler Next(IHandler handler)
        {
            this.handler = handler;
            return this.handler;
        }

        public virtual object Handler(object request)
        {
            if (this.handler != null)
            {
                return this.handler.Handler(request);
            }
            else
            {
                return null;
            }
        }
    }

    public class FirstStep : AbstractHandler
    {
        public override object Handler(object request)
        {
            var number = (NumberEnum)request;
            if (number == NumberEnum.One)
            {
                return true;
            }
            else
            {
                return base.Handler(request);
            }
        }
    }

    public class SecondStep : AbstractHandler
    {
        public override object Handler(object request)
        {
            var number = (NumberEnum)request;
            if (number == NumberEnum.Two)
            {
                return true;
            }
            else
            {
                return base.Handler(request);
            }
        }
    }

    public class ThirdStep : AbstractHandler
    {
        public override object Handler(object request)
        {
            var number = (NumberEnum)request;
            if (number == NumberEnum.Three)
            {
                return true;
            }
            else
            {
                return base.Handler(request);
            }
        }
    }
}
