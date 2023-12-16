using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Assignment
    {
        static void Main(string[] args)
        {
            //take a input from the user 
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Operation do you want to perform (+,-,*,/):  ");
            char UserOperator = Convert.ToChar(Console.ReadLine());

            int Result = 0;

            switch (UserOperator)
            {
                case '+':
                    Result = num1 + num2;
                    break;

                case '-':
                    Result = num1 - num2;
                    break;

                case '*':
                    Result = num1 * num2;
                    break;

                case '/':
                    Result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid Operation ");
                    break;
            }
            Console.WriteLine("...............................................");
            Console.WriteLine("Result : " + Result);

            Console.ReadLine();
        }
    }
}
