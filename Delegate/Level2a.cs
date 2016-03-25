using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Level2a
    {
        //STEP 1: declare delegate and the targeted function
        private delegate void Action(string name);
        private void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public Level2a()
        {
            //STEP 2: create new instance of delegate and bind to function
            Action myDelegate = Hello;

            //STEP 3: invoke delegate => invoke the binded function
            //myDelegate.Invoke("Miller. This is level 2a - using Action for function that return void");
            myDelegate("Miller. This is level 2a - using Action for function that return void");

        }
    }
}
