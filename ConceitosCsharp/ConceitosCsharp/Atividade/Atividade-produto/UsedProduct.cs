using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_produto
{
    public class UsedProduct : Products
    {
        public UsedProduct(string name, double price, DateTime manuFactureDate) : base(name, price)
        {
            ManuFactureDate = manuFactureDate;
        }
        public DateTime ManuFactureDate { get; set; }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" (USED) ");
            sb.Append("$ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append("(Manufacture date: ");
            sb.Append(ManuFactureDate);
            sb.Append(")");
            return sb.ToString();
        }
    }
}
