using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Proxy
{
    public class SubjectProxy : ISubject
    {
        private ISubject subject;

        public SubjectProxy(ISubject subject)
        {
            this.subject = subject;
        }

        public string Operation()
        {
            return $"inside proxy everything is { this.subject.Operation() }";
        }
    }
}
