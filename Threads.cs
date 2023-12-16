using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Threads
    {
        static void Main(string[] args)
        {
            Threads.DoSomething();

            Threads.DoSomethingHeavyLifting();

        }

        public static void DoSomethingHeavyLifting()
        {
            Console.WriteLine("I'm lifiting a truck");
            Thread.Sleep(1000);

            Console.WriteLine("I need a 3 sec of nap");
            Thread.Sleep(1000);

            Console.WriteLine("1......");
            Thread.Sleep(1000);

            Console.WriteLine("2....");
            Thread.Sleep(10000);
        }
        public static void DoSomething()
        {
            Console.WriteLine("Do something");

            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("Im done");
        }
    }
}
