using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace BankApp.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException() : base("Insufficient funds for this withdrawal.") { }

        public InsufficientFundsException(string message) : base(message) { }

        public InsufficientFundsException(string message, Exception inner) : base(message, inner) { }
    }
}
