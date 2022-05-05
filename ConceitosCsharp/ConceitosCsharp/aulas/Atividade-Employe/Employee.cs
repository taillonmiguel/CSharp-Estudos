using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Employe
{
    public class Employee
    {
        public Employee(){}

        public Employee(string nome, int hours, double valuePerHour)
        {
            Nome = nome;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public string Nome { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
