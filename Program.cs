using System;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main method started");

            SomeMethod();

            Console.WriteLine("Main method ends");
            Console.ReadKey();
        }

        public async static void SomeMethod()
        {
           
            Console.WriteLine("SomeMethod started");

            //Thread.Sleep(TimeSpan.FromSeconds(10));
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n");
            Console.WriteLine("SomeMethod end");
           
        }
    }
}
