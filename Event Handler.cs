using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class Event_Handler
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.onCreated += Email.send;
            order.onCreated += SMS.send;

            order.Create();

            Console.ReadLine();
        }
    }

    class Order
    {
        public delegate void orderEventHandler();

        public event orderEventHandler onCreated;
        public void Create()
        {
            Console.WriteLine("Order created");

            if (onCreated != null)
            {
                onCreated();
            }
        }

    }
    class Email
    {
        public static void send()
        {
            Console.WriteLine("send an email");
        }
    }
    class SMS
    {
        public static void send()
        {
            Console.WriteLine("send an SMS");
        }
    }

}
