using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class ActionFuncPredicate
    {

        public void add(int a, int b)
        {
            Console.WriteLine("Addition of two numbers = "+(a+b));
        }
        public int factorial(int a)
        {
            if (a == 1)
                return 1;
            else
                return a * factorial(a - 1);
        }
        public bool Product(int a)
        {
            if (a > 18)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            ActionFuncPredicate afp = new ActionFuncPredicate();

            Action<int, int> a1 = afp.add;
            a1(10, 30);

            Func<int,int> a2 = afp.factorial;
            int ans = a2(10);
            Console.WriteLine("facorial of number = "+ans);

            Predicate<int> a3 = afp.Product;
            bool a = a3(20);
            Console.WriteLine(a);
        }
    }
}
