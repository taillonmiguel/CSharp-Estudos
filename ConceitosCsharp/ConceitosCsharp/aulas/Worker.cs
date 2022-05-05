using ConceitosCsharp.Atividade.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade
{
    public class Worker
    {
        public Worker(){ }

        public Worker(string name, WorkerLevel level, double salarioBase, Departamento departamento)
        {
            Name = name;
            Level = level;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double SalarioBase { get; set; }
        public List<HourContract> Contratos { get; set; } = new List<HourContract>();
        public Departamento Departamento { get; set; }
        
        public void AdicionarContrato(HourContract contrato)
        {
            Contratos.Add(contrato);
        }
        
        public void RemoverContrato(HourContract contrato)
        {
            Contratos.Remove(contrato);
        }

        public double Renda(int ano, int mes) 
        {
            double soma = SalarioBase;

            foreach(HourContract contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }

    }
}
