using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Multi_Thread
    {
        static void Main(string[] args)
        {
            //You will be able to run both functions simultaneously
            Thread firstthread = new Thread(new ThreadStart(func1));
            Thread Secondthread = new Thread(new ThreadStart(func2));

            firstthread.Start();
            Secondthread.Start();



            //without multi-thread function 2 will excecute after function 1
            //func1();
            //Thread.Sleep(9000);
            //func2();

            Console.ReadLine();
        }
        public static void func1()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function 1 writes : {0}",i);
            }
        }
        public static void func2()
        {
            for (int i = 10; i >= 5; i--)
            {
                Console.WriteLine("Function 2 writes : {0}",i);
            }
        }
    }
}
