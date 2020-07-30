using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype.Entities
{
    public class Papaya : IFruit
    {
        public string Warning => "Eu sou um mamão!";

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
