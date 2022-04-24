using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_Employe
{
    public class OutsourcedEmployee : Employee
    {

        public OutsourcedEmployee(string nome, int hours, double valueporhours, double additionalCharge) : 
            base(nome, hours, valueporhours) 
        {
            AdditionalCharge = additionalCharge; 
        }

        public double AdditionalCharge { get; set; }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge ;
        }
    }
}
