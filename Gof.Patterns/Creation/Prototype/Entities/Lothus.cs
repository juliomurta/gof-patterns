using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype.Entities
{
    public class Lothus : IFlower
    {
        public string Warning => "Eu sou uma flor de lótus!";

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
