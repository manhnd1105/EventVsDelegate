using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {
            new Level1();
            new Level2();
            new Level3();
            new Level3EventInvoker();
            Console.ReadKey();
        }
    }
}
