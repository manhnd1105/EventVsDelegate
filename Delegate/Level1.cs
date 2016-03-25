using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Level1
    {
        //STEP 1 : declare new delegate (function pointer)
        delegate string DelegateHello(string name);
        private string Hello(string name)
        {
            Console.WriteLine("Hello " + name);
            return "";
        }

        public Level1()
        {
            //STEP 2 : create new instance of the defined delegate that binded to a function
            DelegateHello myDelegate = Hello;

            //STEP 3: invoke delegate => invoke the binded function
            //myDelegate.Invoke("Miller. This is level 1 - using the pure delegate keyword");
            myDelegate("Miller. This is level 1 - using the pure delegate keyword");
        }
    }
}
