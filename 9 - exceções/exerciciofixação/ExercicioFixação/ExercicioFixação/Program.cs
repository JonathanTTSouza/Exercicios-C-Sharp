using ExercicioFixação.Entities;
using ExercicioFixação.Entities.Exceptions;
using System;
using System.Globalization;

namespace ExercicioFixação
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, withdrawLimit);

                Console.WriteLine();

                Console.Write("Enter amount for Withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account.Withdraw(amount);

                Console.Write("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
