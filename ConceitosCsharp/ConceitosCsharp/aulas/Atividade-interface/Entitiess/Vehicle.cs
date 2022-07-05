using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.aulas.Atividade_interface.Entitiess
{
    public class Vehicle
    {
        public Vehicle(){ }
        public Vehicle(string model)
        {
            Model = model;
        }
        public string Model { get; set; }
    }
}
