using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.FactoryMethod.Entities.Office
{
    public class OfficeFactory : Factory
    {
        public override Door MakeDoor()
        {
            return new OfficeDoor();
        }

        public override Wall MakeWall()
        {
            return new OfficeWall();
        }
    }
}
