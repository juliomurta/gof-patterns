using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gof.Patterns.Creation.Singleton
{
    public class MyInstance
    {
        private static MyInstance instance = null;

        private MyInstance()
        {

        }

        public static MyInstance Instance()
        {
            if (instance == null)
            {
                instance = new MyInstance();
            }

            return instance;
        }
    }
}
