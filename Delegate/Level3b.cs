using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Level3b
    {
        //STEP 1: declare the delegate => No need because we'll use anonymous delegate (function)
        private bool TryHello(string name)
        {
            Console.WriteLine("Hello " + name);
            return true;
        }

        public Level3b()
        {
            //STEP 2: make new istance of delegate and point to function
            Action myDelegate = (() => TryHello("Miller. This is level 3b - using anonymous delegate with function"));

            //STEP 3: invoke delegate
            //myDelegate.Invoke();
            myDelegate();
        }
    }
}
