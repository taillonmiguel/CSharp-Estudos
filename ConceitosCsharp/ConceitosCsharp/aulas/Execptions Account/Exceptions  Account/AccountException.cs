using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosCsharp.Atividade.Execptions_Account.Exceptions__Account
{
    public class AccountException : ApplicationException
    {
        public AccountException(string message): base(message)
        {

        }
    }
}
