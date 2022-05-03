using ConceitosCsharp.Atividade;
using ConceitosCsharp.Atividade.Atividade;
using ConceitosCsharp.Atividade.Atividade.Enum;
using ConceitosCsharp.Atividade.Atividade_Employe;
using ConceitosCsharp.Atividade.Atividade_Pessoa;
using ConceitosCsharp.Atividade.Atividade_Post;
using ConceitosCsharp.Atividade.Atividade_produto;
using ConceitosCsharp.Atividade.Atividade_Shapee;
using ConceitosCsharp.Atividade.Atividade_Shapee.Enum_Shapee;
using ConceitosCsharp.Atividade.Enum;
using ConceitosCsharp.Atividade.Reservation;
using ConceitosCsharp.Atividade.Reservation.Execptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ConceitosCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecesaoReservation();
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


            for (int i = 1; i <= quantidade; i++)
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
        public static void Employeer()
        {
            List<Employee> employees = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int quantidade = int.Parse(Console.ReadLine());
            for (int i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced(Y/N)? ");
                char opc = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opc == 'y' || opc == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double additional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employees.Add(new OutsourcedEmployee(name, hours, valuePerHour, additional));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Nome + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
        public static void Producto()
        {
            List<Products> product = new List<Products>();
            Console.Write("Enter the number of products: ");
            int quantidade = int.Parse(Console.ReadLine());
            for (var i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Product {i} data: ");
                Console.Write("Commom used, or imported (c/u/i)? ");
                char opc = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opc == 'I' || opc == 'i')
                {
                    Console.WriteLine("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product.Add(new ImportedProduct(name, price, customFee));
                }
                else if (opc == 'u' || opc == 'U')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct(name, price, manufacture));
                }
                else if (opc == 'c' || opc == 'C')
                {
                    product.Add(new Products(name, price));
                }
            }

            foreach (var item in product)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
        public static void Area()
        {
            List<Shapee> shapee = new List<Shapee>();
            Console.Write("Enter the number of shapees: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (var i = 1; i <= quantidade; i++)
            {
                Console.WriteLine($"Shapee #{i} data: ");
                Console.Write("Rectangle or Circle? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (type == 'R' || type == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Heigth: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapee.Add(new Rectangle(color, width, height));
                }
                else if (type == 'C' || type == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapee.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");
            foreach (var shape in shapee)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
        public static void CalcularImpostoPessoa()
        {
            List<Pessoa> pessoa = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write("Individual or company (i/c)? ");
                char opc = char.Parse(Console.ReadLine());
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(opc == 'I' || opc == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastosCOmsaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa.Add(new PessoaFisica(gastosCOmsaude, name, rendaAnual));
                }
                else if(opc == 'C' || opc == 'c')
                {
                    Console.Write("Number of employess: ");
                    int quantidadeDePessoas = int.Parse(Console.ReadLine());
                    pessoa.Add(new PessoaJuridica(quantidadeDePessoas, name, rendaAnual));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes PAID: ");
            double soma = 0.0;
            foreach(var item in pessoa)
            {
                Console.WriteLine(item.Nome + ": $ "+ item.Imposto().ToString("F2", CultureInfo.InvariantCulture));
                soma += item.Imposto();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
        public static void Excesao()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);                
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
           
        }
        public static void ExecesaoReservation()
        {            
            try
            {                
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());
                Reservation reservation = new(number, checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


                Console.WriteLine();
                Console.WriteLine("Enteder data to update the reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());
                reservation = new(number, checkIn, checkOut);
                reservation.Duration();

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + reservation);


            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro " + e.Message);         
            }
            
            
        }
    }
}
