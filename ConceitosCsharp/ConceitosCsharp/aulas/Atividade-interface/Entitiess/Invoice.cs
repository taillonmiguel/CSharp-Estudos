﻿using System;
using System.Globalization;

namespace ConceitosCsharp.aulas.Atividade_interface.Entitiess
{
    public class Invoice
    {
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double BasicPayment { get; set; }
        public double Tax { get; set; }
        public double TotalPayment 
        { 
            get { return BasicPayment + Tax; } 
        }
        public override string ToString()
        {
            return "Basic Payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                +"\nTotalPayment: "
                +TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
