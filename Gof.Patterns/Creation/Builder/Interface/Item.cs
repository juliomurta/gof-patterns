using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Builder.Interface
{
    public interface Item
    {
        string Name();

        Packing Packing { get; }

        decimal Price();
    }
}
