using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class HelloEventArgs : EventArgs
    {
        public string Name { get; set; }
    }

    class Level2
    {
        //STEP 1: declare event which has object type (handler) being a delegate. No need to declare delegate because we'll use bult-in EventHandler delegate
        private event EventHandler<HelloEventArgs> myEvent;
        private void Hello(object sender, HelloEventArgs args)
        {
            Console.WriteLine("Hello " + args.Name);
        }
        private void Hi(object sender, HelloEventArgs args)
        {
            Console.WriteLine("Hi " + args.Name);
        }

        public Level2()
        {
            //STEP 2: create new instance of event and point function to it
            myEvent += new EventHandler<HelloEventArgs>(Hello);
            myEvent += new EventHandler<HelloEventArgs>(Hi);

            //STEP 3: invoke the event
            //myEvent.Invoke(this, new HelloEventArgs() { Name = "Miller. This is level 2 - using EventHandler delegate" });
            myEvent(this, new HelloEventArgs() { Name = "Miller. This is level 2 - using EventHandler delegate" });
        }
    }
}
