using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class MyDelegates
    {

        public delegate void myDelegate(int a, int b);
        public delegate void mydelegate2(string a);

        static void Addition(int a, int b)
        {
            Console.WriteLine("Addition of two Numbers = " + (a + b));
        }
        void Greet(string a)
        {
            Console.WriteLine("Welcome to this channel = " + a);
        }
        static void Main(string[] args)
        {
            MyDelegates del = new MyDelegates();

            //Single cast delegate 
            myDelegate mydel = new myDelegate(MyDelegates.Addition);//static method
            mydel(10, 20); mydel(30, 40);

            Console.WriteLine("..............................................................................................");

            mydelegate2 mydel2 = new mydelegate2(del.Greet);//Non static method
            mydel2("Technical Guruji"); mydel2("Gaurav Chaudhary");
            Console.ReadLine();
        }
    }
}
