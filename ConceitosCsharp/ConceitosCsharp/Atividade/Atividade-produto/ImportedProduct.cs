using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Atividade_produto
{
    public class ImportedProduct : Products
    {
        public ImportedProduct(){ }
        public ImportedProduct(string name, double price, double customFee) : base (name, price)
        {
            CustomsFee = customFee;
        }
        public double CustomsFee { get; set; }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name);
            sb.Append(" $ ");
            sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomsFee);
            sb.Append(")");
            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

    }
}
