using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class MultiCastDelegate
    {
        //Multicast delegate
        public delegate void myDel(double width, double height);

        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectangle = "+(width*height));
        }
        public void GetPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter of rectangle= " + (2*width * height));
        }
        static void Main(string[] args)
        {
            MultiCastDelegate md = new MultiCastDelegate();

            myDel m1 = new myDel(md.GetArea);
           
           
            m1 += md.GetPerimeter;

            m1(345.11, 567.22);
            m1(564.57, 576.22);

            Console.ReadLine();

        }
    }
}
