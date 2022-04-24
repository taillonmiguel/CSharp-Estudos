using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Pessoa
{
    public abstract class Pessoa
    {
        public Pessoa() {  }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public abstract double Imposto();
    }
}
