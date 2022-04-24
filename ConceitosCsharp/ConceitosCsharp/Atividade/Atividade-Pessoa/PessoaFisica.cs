using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Pessoa
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(){ }
        public PessoaFisica(double gastosComSaude, string nome, double rendaMensal) : base(nome, rendaMensal)
        {
            GastosComSaude = gastosComSaude;
        }
        public double GastosComSaude { get; set; }

        public override double Imposto()
        {
            var imposto = RendaAnual < 20000 ? RendaAnual * 0.15 : RendaAnual * 0.25;

            var gastoComSaude = GastosComSaude != 0 ? GastosComSaude * 0.50 : 0.0;

            return imposto - gastoComSaude;            
        }
    }
}
