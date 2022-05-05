using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade
{
    public class Departamento
    {

        public Departamento(){ }
        
        public Departamento(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
    }
}
