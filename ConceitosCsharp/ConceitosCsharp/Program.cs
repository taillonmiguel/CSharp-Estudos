using ConceitosCsharp.Atividade;
using ConceitosCsharp.Atividade.Atividade_Post;
using ConceitosCsharp.Atividade.Enum;
using ConceitosCsharp.Classes;
using ConceitosCsharp.Classes.Enums;
using System;
using System.Globalization;

namespace ConceitosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Comentar();
        }
        public static void Trab()
        {
            Console.Write("Enter Departament's name: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salario Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Criando Objeto Departamento
            Departamento departament = new Departamento(departamento);
            //Criando Objeto Worker com os parametros
            Worker worker = new Worker(nome, level, salarioBase, departament);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int quantidade = int.Parse(Console.ReadLine());
            //Criando *HourContract*
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Enter {i} contract data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Vaalor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                //Adicionado no objeto HourContract
                HourContract contrato = new HourContract(data, valorPorHora, hours);
                worker.AdicionarContrato(contrato);
            }
            Console.Write("Entre com o mês e ano para calcular o ganho (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departamento" + worker.Departamento.Nome);
            Console.WriteLine("Income for" + mesEAno + ": " + worker.Renda(ano, mes));
        }

        public static void Comentar()
        {
            Comment primeiroComentario = new Comment("Have a nice trip");
            Comment segundoComentario = new Comment("")

            Console.WriteLine("Momento: ");
            DateTime momento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Conteudo: ");
            string conteudo = Console.ReadLine();
            Console.WriteLine("Likes: ");
            int likes = int.Parse(Console.ReadLine());

            Post post = new Post(momento, titulo, conteudo, likes);



        }
    }
}
