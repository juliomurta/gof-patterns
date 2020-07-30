using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype.Entities
{
    public class Ype : ITree
    {
        public string Warning { get => "Eu sou um ypê-roxo!"; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
