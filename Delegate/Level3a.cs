using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Level3a
    {
        //STEP 1: Declare delegate => No need because we'll use anonymous
        private void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public Level3a()
        {
            //STEP 2: create new instance of delegate and point it to function
            Action myDelegate = delegate() { Hello("Miller. This is level 3a - using anonymous delegate (action) that parameters are passed right in delegate creation"); };

            //STEP 3: invoke delegate
            //myDelegate.Invoke();
            myDelegate();

        }
    }
}
