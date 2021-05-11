using ExercicioFixacao.Entities;
using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data: ");

            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());

            Contract contrato = new Contract(number, date, contractValue);

            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Installment installment = new Installment()

            
        }
    }
}
