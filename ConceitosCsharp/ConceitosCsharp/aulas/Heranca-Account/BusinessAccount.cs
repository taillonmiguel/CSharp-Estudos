using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Heranca_Account
{
    public class BusinessAccount : Account
    {
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number,holder,balance)
        {
            LoanLimit = loanLimit;
        }
        public double LoanLimit { get; set; }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit)
                Balance += amount;
        }

    }
}
