using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class AnoyonomousMethod
    {
        public delegate void Addition(int a, int b);

        //static void Addition(int a, int b)
        //{
        //    Console.WriteLine("Addition" + (a + b));
        //}

        static void Main(string[] args)
        {
            Addition mydel = delegate (int a, int b)
            {
                Console.WriteLine("Addition = " + (a + b));
            };
            mydel(10, 20);
            Console.ReadLine();
        }
    }
}
