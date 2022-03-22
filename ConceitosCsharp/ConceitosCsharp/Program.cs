using ConceitosCsharp.Classes;
using ConceitosCsharp.Classes.Enums;
using System;

namespace ConceitosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            order.Id = 1080;
            order.Moment = DateTime.Now;
            order.Status = OrderStatus.PendingPayment;

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}
