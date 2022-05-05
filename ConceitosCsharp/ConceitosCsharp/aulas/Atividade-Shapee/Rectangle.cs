using ConceitosCsharp.Atividade.Atividade_Shapee.Enum_Shapee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Shapee
{
    public class Rectangle : Shapee
    {
        public Rectangle(Color color, double width, double high) : base(color)
        {
            Width = width;
            High = high;
        }
        public double Width { get; set; }
        public double High { get; set; }

        public override double Area()
        {
            return High * Width;
        }
    }
}
