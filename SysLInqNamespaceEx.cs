using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class SysLInqNamespaceEx
    {
        static void Main(string[] args)
        {
            //list of integers 
            List<int> numbers = new List<int> { 10, 25, 8, 4, 14, 18, 30 ,5 };

            //LINQ query to get evennumber

            //Query Syntax
            var ListOfNumbers1 = from number in numbers
                                 where number % 2 == 0
                                 select number;

            //Method Syntax
            var ListOfNumbers2 = numbers.Where(num => num % 2 == 0);

            Console.WriteLine("Even Number");
            foreach (var n in ListOfNumbers1)
            {
                Console.WriteLine(n);
            }

            //LINQ query  to get the sum of all numbers
            int sum = numbers.Sum();
            Console.WriteLine("Sum : "+sum);

            //Find Maximum and Minimum
            int max = numbers.Max();
            Console.WriteLine("Max : "+max);

            int min = numbers.Min();
            Console.WriteLine("Min : " + min);


            //LINQ query to get numbers in acending order
            //Query syntax
            var OrderNum1 = from number in numbers
                           orderby number
                           select number;

            var OrderNum2 = numbers.OrderBy(num => num);
            Console.WriteLine("Numbers in Acending order");

            foreach (var n in OrderNum1)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
