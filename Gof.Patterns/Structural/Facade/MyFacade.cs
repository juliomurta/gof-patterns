using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Structural.Facade
{
    public class SubSystem1
    {
        public int GimmeOne()
        {
            return 1;
        }

        public int GimmeTwo()
        {
            return 2;
        }

        public int GimmeThree()
        {
            return 3;
        }

        public int GimmeFour()
        {
            return 4;
        }
    }

    public class SubSystem2
    {
        public int GimmeTen()
        {
            return 10;
        }

        public int GimmeTwenty()
        {
            return 20;
        }

        public int GimmeThirty()
        {
            return 30;
        }
    }

    public class MyFacade
    {
        private SubSystem1 sub1;

        private SubSystem2 sub2;

        public MyFacade(SubSystem1 sub1, SubSystem2 sub2)
        {
            this.sub1 = sub1;
            this.sub2 = sub2;
        }

        public int GimmeSeventy()
        {
            //Let's suppose it's a complex operation, ok?
            return this.sub1.GimmeOne() +
                   this.sub1.GimmeTwo() +
                   this.sub1.GimmeThree() +
                   this.sub1.GimmeFour() +
                   this.sub2.GimmeTen() +
                   this.sub2.GimmeTwenty() +
                   this.sub2.GimmeThirty(); 
        }
    }
}
