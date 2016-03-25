using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Level3
    {
        //STEP 1: declare event with object type being a delegate EventHandler
        protected EventHandler<HelloEventArgs> myEvent;     //In fact often be named "OnHelloExecuted"
        private void Hello(object sender, HelloEventArgs args)
        {
            Console.WriteLine("Hello " + args.Name);
        }
        private void Hi(object sender, HelloEventArgs args)
        {
            Console.WriteLine("Hi " + args.Name);
        }

        public Level3()
        {
            //STEP 2: create new event instances that bind to function
            myEvent += new EventHandler<HelloEventArgs>(Hello);
            myEvent += new EventHandler<HelloEventArgs>(Hi);
        }
    }

    class Level3EventInvoker : Level3
    {
        public Level3EventInvoker()
        {
            myEvent(this, new HelloEventArgs() { Name = "Miller. This is level 3 - Using separated and invoker from inherited class"});
        }
    }
}
