using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    interface IWishable
    {
         void greet(string msg);


    }
    interface IMath
    {
        void add(int a, int b);
        int divide(int a, int b);
    }
    class MyInterfaces : IMath, IWishable
    {
        public void greet(string msg)
        {
            Console.WriteLine("Welcome to Systems Plus Family.." + msg);
        }
        public void add(int a, int b)
        {
            Console.WriteLine("Addition = " + (a+b));
        }
        public int divide(int a,int b)
        {
            int result = a / b;
            return result;
        }
        static void main(string[] args)
        {
            IMath m1 = new MyInterfaces();

            m1.add(10, 20);
            int ans = m1.divide(10, 20);
            Console.WriteLine("Division of two numbers = " + ans);
            

        }

    }
}
