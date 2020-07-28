
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.FactoryMethod.Entities
{
    public class Factory
    {
        public virtual Door MakeDoor()
        {
            return new Door();
        }

        public virtual Wall MakeWall()
        {
            return new Wall();
        }
    }
}
