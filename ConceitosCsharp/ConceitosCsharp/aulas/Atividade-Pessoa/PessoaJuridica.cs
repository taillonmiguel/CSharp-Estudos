using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Pessoa
{
    public class PessoaJuridica : Pessoa
    {
        public PessoaJuridica() { }

        public PessoaJuridica(int numeroDeFuncionario, string nome, double rendaAnual) : base(nome, rendaAnual)
        {
            NumeroDeFuncionarios = numeroDeFuncionario;
        }

        public int NumeroDeFuncionarios { get; set; }

        public override double Imposto()
        {
           double imposto = NumeroDeFuncionarios > 10 ? RendaAnual * 0.14: RendaAnual * 0.16;            

            return imposto;
        }
    }
}
