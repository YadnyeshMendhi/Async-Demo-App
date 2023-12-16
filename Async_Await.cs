using System;
using System.Threading;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Async_Await
    {
        //Asynchronomous Method
        static void Main(string[] args)
        {
            demo();
            Console.ReadLine();
        }
        public static void demo()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            var task1 = StartSchoolAssembly();
            var task2 = TeachClass12();
            var task3 = TeachClass11();

            Task.WaitAll(task1, task2, task3);
            watch.Stop();
            Console.WriteLine($"Excecution Time : {watch.ElapsedMilliseconds} ms");

        }
        public async static Task StartSchoolAssembly()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(8000);
                Console.WriteLine("School Started");
            });
        }
        public async static Task TeachClass12()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Taught class 12");
            });
        }
        public async static Task TeachClass11()
        {
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Taught class 11");
            });
            
        }
    }
}
