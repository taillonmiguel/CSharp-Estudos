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
using ConceitosCsharp.Atividade.Execptions_Account;
using ConceitosCsharp.Atividade.Execptions_Account.Exceptions__Account;
using ConceitosCsharp.Atividade.Reservation;
using ConceitosCsharp.Atividade.Reservation.Execptions;
using ConceitosCsharp.aulas.Atividade_interface.Entitiess;
using ConceitosCsharp.aulas.Atividade_interface.Entitiess.ServiceRuim;
using ConceitosCsharp.aulas.AtividadeFileIO;
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
            var resultado = Impares(2, 5);
            
            resultado.ForEach(x=> Console.WriteLine(x));

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

                if (opc == 'I' || opc == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double gastosCOmsaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoa.Add(new PessoaFisica(gastosCOmsaude, name, rendaAnual));
                }
                else if (opc == 'C' || opc == 'c')
                {
                    Console.Write("Number of employess: ");
                    int quantidadeDePessoas = int.Parse(Console.ReadLine());
                    pessoa.Add(new PessoaJuridica(quantidadeDePessoas, name, rendaAnual));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Taxes PAID: ");
            double soma = 0.0;
            foreach (var item in pessoa)
            {
                Console.WriteLine(item.Nome + ": $ " + item.Imposto().ToString("F2", CultureInfo.InvariantCulture));
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
            catch (DirectoryNotFoundException e)
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
        public static void Excessao()
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withdrawLimit);

            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(amount);
                Console.WriteLine(account);
            }
            catch (AccountException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public static void PrimeiroFile()
        {
            var lerDados = @"c:\prova\sumary.csv";
            var dadosCopiados = @"C:\prova\sumarycopy.csv";
            try
            {
                //associando objeto ao fileInfo.
                FileInfo fileInfo = new FileInfo(lerDados);
                //uso a operação CopyTo e copio o arquivo do lerDados para dadosCopiados.
                fileInfo.CopyTo(dadosCopiados);
                //usar a classe statica File para ler todas as linhas associada ao arquivo 
                string[] lines = File.ReadAllLines(dadosCopiados); 
                foreach(var item in lines)
                {
                    Console.WriteLine(item);
                    
                }

            }
            catch(IOException ex)
            {
                Console.WriteLine("ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
        public static void SegundoVideo()
        {
            var lerDados = @"c:\prova\sumary.csv";
            //FileStream filStream = null;
            StreamReader streamReader = null;

            try
            {
                //filStream = new FileStream(lerDados, FileMode.Open);
                streamReader = File.OpenText(lerDados);                
                while (!streamReader.EndOfStream)
                {
                    //lendo a linha
                    var Lerlinha = streamReader.ReadLine();
                    //escrevendo a linha na tela
                    Console.WriteLine(Lerlinha);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Ocorreu um erro\n" + ex.Message );
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
                /*if(filStream != null)
                {
                    filStream.Close();
                }*/
            }
        }
        public static void TerceiroVideoUsing()
        {
            //variavel para ter o caminho do arquivo.
            var arquivo = @"c:\prova\sumary.csv";
            try
            {
               // using (var fileStream = new FileStream(arquivo, FileMode.Open))
              //  {
                    using (var streamReader = File.OpenText(arquivo))
                    {
                        while (!streamReader.EndOfStream)
                        {
                            //lendo a linha
                            var linha = streamReader.ReadLine();
                            //escrevar a linha
                            Console.WriteLine(linha);
                        }
                    }
               // }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
        public static void AtividadeFixacaoIo()
        {
            Console.WriteLine("Enter file full path: ");
            string sourceFilePath = @"c:\prova\texto.csv";

            try
            {
                //lendo todas as linhas
                string[] lines = File.ReadAllLines(sourceFilePath);

                //procuro a pasta do arquivo
                var sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                 var targeFolderPath = sourceFolderPath + @"\out";
                var targeFilePath = targeFolderPath + @"\summary.csv";
                //crio a pasta
                Directory.CreateDirectory(targeFolderPath);
                using(StreamWriter sw = File.AppendText(targeFilePath))
                {
                    foreach(var item in lines)
                    {
                        //separar o nome, preço, quantidade por virgula
                        string[] posiccao = item.Split(',');
                        var name = posiccao[0];
                        var price = double.Parse(posiccao[1], CultureInfo.InvariantCulture);
                        var quantidade = int.Parse(posiccao[2]);

                        var produto = new ProductIO(quantidade, name, price);
                        //salvo esses itens na pasta sumarry
                        sw.WriteLine(produto.Name + "," + produto.Total().ToString("F2", CultureInfo.InvariantCulture));
                        //escrevo na tela
                        Console.WriteLine(produto.Name + "," + produto.Total().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }

            }
            catch(IOException ex)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(ex.Message);
            }
        }
        public static void Aluguel()
        {
            Console.WriteLine("Enter rental data");
            Console.WriteLine("Car Model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), 
                "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return (dd/MM/yy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), 
                "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            
            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);

        }

        public static List<int> Impares(int l, int r)
        {
            var a = new List<int>();
            for (var i = l; i<=r; i++)
            {                
                if(i % 2 !=0 )
                {
                    a.Add(i);
                }
            }

            return a;
            
        }
    }
}
