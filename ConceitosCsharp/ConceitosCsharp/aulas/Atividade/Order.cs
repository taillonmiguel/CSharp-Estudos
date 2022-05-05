using ConceitosCsharp.Atividade.Atividade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade
{
    public class Order
    {
        public Order()
        {

        }
        public Order( OrderStatus status, Client myProperty)
        {
            Date = DateTime.Now;
            Status = status;
            MyProperty = myProperty;
        }

        public DateTime Date { get; set; }
        public OrderStatus Status{ get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client MyProperty { get; set; }

        public void AddItem(OrderItem orderItem)
        {
            OrderItem.Add(orderItem);
        }
        public void RemoveItem(OrderItem orderItem)
        {
            OrderItem.Remove(orderItem);
        }
        public double Total()
        {
            var soma = 0.0;
            foreach(var item in OrderItem)
            {
                soma = item.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary");
            sb.Append("Order Moment");
            sb.AppendLine(Date.ToString());
            sb.Append(Status);
            sb.AppendLine("Client");
            sb.Append(MyProperty.Name);
            sb.Append(MyProperty.Email);
            sb.Append(MyProperty.BirthDate);
            sb.AppendLine("Order Items: ");        
            foreach(var item in OrderItem)
            {
                sb.Append(item.Product.Name);
                sb.Append(", $");
                sb.Append(item.Price);
                sb.Append(" ,");
                sb.Append("Quantity: ");
                sb.Append(item.Quantidade);
                sb.Append(" Susbtotal: ");
                sb.Append(item.SubTotal());
            }
            return sb.ToString();

        }
    }
}
