using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Post
{
    public class Comment
    {
        public Comment(string texto)
        {
            Texto = texto;
        }
        public string Texto { get; set; }
    }
}
