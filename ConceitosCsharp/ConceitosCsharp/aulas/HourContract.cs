using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade
{
    public class HourContract
    {
        public HourContract(){}
        public HourContract(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}
