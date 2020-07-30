using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype.Entities
{
    public class Pine : ITree
    {
        public string Warning => "Eu sou um pinheiro!";

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
