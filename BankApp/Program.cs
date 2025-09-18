using System;
using BankApp.Exceptions;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc account = new BankAcc(5000);
            Console.WriteLine($"Initial balance: {account.Balance:C}");

            try
            {
                Console.Write("Enter withdrawal amount: ");
                double withdrawalAmount = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(withdrawalAmount);
                Console.WriteLine($"Withdrawal successful! New balance: {account.Balance:C}");
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for withdrawal.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
