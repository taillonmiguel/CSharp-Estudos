using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade
{
    public class OrderItem
    {
        public OrderItem(){ }

        public OrderItem(int quantidade, double price, Product product)
        {
            Quantidade = quantidade;
            Price = price;
            Product = product;
        }

        public int Quantidade { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
        public double SubTotal()
        {
            return Quantidade * Price;
        }
    }
}
