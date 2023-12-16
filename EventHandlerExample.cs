using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_demo_app
{
    class EventHandlerExample
    {
        static void Main(string[] args)
        {
            var order = new Order();

            order.OnCreated += Email.Send;
            order.OnCreated += SMS.Send;

            order.Create("YadyneshMendhi@gmail.com", "8010927440");

            Console.ReadLine();
        }

        class OrderEventArgs : EventArgs
        {
            public string Email { get; set; }
            public string Phone { get; set; }
        }
        
        class Order
        {
            public event EventHandler<OrderEventArgs> OnCreated;

            public void Create(string email, string phone)
            {
                Console.WriteLine(string.Join("....................", "Order created"));

                if (OnCreated != null)
                {
                    OnCreated(this, new OrderEventArgs { Email = email, Phone = phone });
                }
            }
        }

        class Email
        {
            public static void Send(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"Send an email to {e.Email}");
            }
        }

        class SMS
        {
            public static void Send(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"Send an SMS to {e.Phone}");
            }
        }

    }  
    
}
