using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Level1
    {
        //STEP 1: declare new event that object type (handler) is a delegate
        private delegate bool DelegateTryHello(string name);
        event DelegateTryHello myEvent;
        private bool TryHello(string name)
        {
            Console.WriteLine("Hello " + name);
            return true;
        }
        private bool TryHi(string name)
        {
            Console.WriteLine("Hi " + name);
            return true;
        }

        public Level1()
        {
            //STEP 2: create new event instances and bind function to it
            myEvent += new DelegateTryHello(TryHello);  //An event can contains many delegates => Event is delegates' container => Event can broadcast
            myEvent += new DelegateTryHello(TryHi);
            Console.WriteLine("An event can contains many delegates => Event is delegates' container => Event can broadcast");
            Console.WriteLine("Event handler is a delegate that acts like a provider");


            //STEP 3: invoke the event
            //myEvent.Invoke("Miller. This is level 1 - pure event with pure delegate");
            myEvent("Miller. This is level 1 - pure event with pure delegate");
        }
    }
}
