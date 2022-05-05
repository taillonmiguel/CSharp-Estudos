using ConceitosCsharp.Atividade.Execptions_Account.Exceptions__Account;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Execptions_Account
{
    public class Account
    {
        public Account() {  }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public void Deposit(double amount)
        {
            if(amount == 0)
            {
                throw new AccountException("o deposito não pode ser zero!");
            }
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if(Balance < amount)
            {
                throw new AccountException("Withdraw error: não há saldo suficiente");
            }
            if(WithdrawLimit < amount)
            {
                throw new AccountException("Withdraw error: The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "New balance"
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
