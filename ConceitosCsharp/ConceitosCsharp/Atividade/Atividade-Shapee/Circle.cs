using ConceitosCsharp.Atividade.Atividade_Shapee.Enum_Shapee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Shapee
{
    public class Circle : Shapee
    {
        public Circle(double radius, Color color): base(color)
        {
            Radius = radius;
        }

        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
