using ConceitosCsharp.Atividade.Atividade_Shapee.Enum_Shapee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Shapee
{
    public abstract class Shapee
    {
        public Shapee() { }
        public Shapee(Color color)
        {
            Color = color;
        }
        public Color Color { get; set; }

        public abstract double Area();
    }
}
