using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Post
{
    public class Post
    {

        public Post()
        {

        }
        public Post(DateTime momment, string title, string content, int likes)
        {
            Momment = momment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public DateTime Momment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comentarios { get; set; } = new List<Comment>();

        public void AdicionarComentario(Comment comment)
        {
            Comentarios.Add(comment);
        }
        public void RemoverComentarios(Comment comment)
        {
            Comentarios.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.Append(Momment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");
            foreach(var c in Comentarios)
            {
                sb.AppendLine(c.Texto);
            }
            return sb.ToString();
        }
    }
}
