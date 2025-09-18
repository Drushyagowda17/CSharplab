using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankApp.Exceptions;

namespace BankApp
{
    public class BankAcc
    {
        public double Balance { get; private set; }

        public BankAcc(double initialBalance)
        {
            Balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new InsufficientFundsException("The withdrawal amount exceeds the available balance.");
            }

            Balance -= amount;
        }
    }
}
