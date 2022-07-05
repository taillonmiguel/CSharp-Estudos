using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.aulas.AtividadeFileIO
{
    public class ProductIO
    {
        public ProductIO(){ }

        public ProductIO(int quantity, string name, double price)
        {
            Quantity = quantity;
            Name = name;
            Price = price;
        }

        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public double Total()
        {
            return Quantity * Price;
        }
    }
}
