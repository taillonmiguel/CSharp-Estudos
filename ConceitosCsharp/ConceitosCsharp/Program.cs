using ConceitosCsharp.Atividade;
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

            Console.Write("Enter Departament's name: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Enter Worker data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salario Base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento departament = new Departamento(departamento);
            Worker worker = new Worker(nome, level, salarioBase, departament);

            Console.Write("Quantos contratos para esse trabalhador? ");
            int quantidade = int.Parse(Console.ReadLine());
            for(int i =1; i<= quantidade; i++)
            {
                Console.WriteLine($"Enter {i} contract data: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Vaalor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração (horas): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contrato = new HourContract(data, valorPorHora, hours);
                worker.AdicionarContrato(contrato);
            }
            Console.Write("Entre com o mês e ano para calcular o ganho (MM/YYYY): ");
            string mesEAno = Console.ReadLine();
            int mes = int.Parse(mesEAno.Substring(0, 2));
            int ano = int.Parse(mesEAno.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departamento" + worker.Departamento.Nome);
            Console.WriteLine("Income for" + mesEAno + ": " + worker.Renda(ano,mes));

        }
    }
}
