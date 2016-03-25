using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Level2b
    {
        //STEP 1: declare a delegate and the target function
        private delegate bool Function(string name);
        private bool Hello(string name)
        {
            Console.WriteLine("Hello " + name);
            return true;
        }

        public Level2b()
        {
            //STEP 2: make new instance of delegate and bind it to function
            Function myDelegate = Hello;

            //STEP 3: invoke the delegate => invoke function
            //myDelegate.Invoke("Miller. This is level 2b - using Function with function that return result");
            myDelegate("Miller. This is level 2b - using Function with function that return result");
        }
    }
}
