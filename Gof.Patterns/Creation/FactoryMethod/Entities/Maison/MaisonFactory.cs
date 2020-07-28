using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.FactoryMethod.Entities.Maison
{
    public class MaisonFactory : Factory
    {
        public override Door MakeDoor()
        {
            return new MaisonDoor();
        }

        public override Wall MakeWall()
        {
            return new MaisonWall();
        }
    }
}
