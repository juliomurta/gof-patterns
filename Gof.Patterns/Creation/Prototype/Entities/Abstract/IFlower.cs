using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Prototype.Entities
{
    public interface IFlower : ICloneable
    {
        string Warning { get; }
    }
}
