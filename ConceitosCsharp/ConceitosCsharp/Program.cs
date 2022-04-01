using ConceitosCsharp.Atividade;
using ConceitosCsharp.Atividade.Atividade;
using ConceitosCsharp.Atividade.Atividade.Enum;
using ConceitosCsharp.Atividade.Atividade_Post;
using ConceitosCsharp.Atividade.Enum;

using System;
using System.Globalization;

namespace ConceitosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Order();
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
            Comment segundoComentario = new Comment("nice do nice");

            Console.WriteLine("Momento: ");
            DateTime momento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Titulo: ");
            string titulo = Console.ReadLine();
            Console.WriteLine("Conteudo: ");
            string conteudo = Console.ReadLine();
            Console.WriteLine("Likes: ");
            int like = int.Parse(Console.ReadLine());

            Post post = new Post(momento, titulo, conteudo, like);
            post.AdicionarComentario(primeiroComentario);
            post.AdicionarComentario(segundoComentario);

            Comment c1 = new Comment("houve um equivico");
            Comment c2 = new Comment("Oloco Bixo");

            Console.WriteLine("Momento: ");
            DateTime dataMomento = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Titulo: ");
            string titulos = Console.ReadLine();
            Console.WriteLine("Conteudo: ");
            string conteudos = Console.ReadLine();
            Console.WriteLine("Likes: ");
            int likes = int.Parse(Console.ReadLine());

            Post pos2 = new Post(dataMomento, titulos, conteudos, likes);
            Console.WriteLine(pos2);
            Console.WriteLine(post);
        }
        public static void Order()
        {
            Order orders = new Order();
            Console.WriteLine("Enter Cliente data: ");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(nome, email, birthDate);

            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int quantidade = int.Parse(Console.ReadLine());


            for(int i = 1; i<=quantidade; i++)
            {
                Console.WriteLine($"Enter #{i} item data");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                orders = new Order(orderStatus, client);
                orders.AddItem(orderItem);
            }

            Console.WriteLine(orders);

        }
    }
}
