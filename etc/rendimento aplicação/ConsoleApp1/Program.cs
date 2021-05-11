using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa pra simular rendimento de aplicação com juros de 3.36% mensais");

            Console.Write("Meses: " );
            int n = int.Parse(Console.ReadLine());

            Console.Write("Investimento: ");
            double investimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i<= n; i++)
            {
                Console.Write($"Mês {i}: ");
                investimento += investimento * 0.0336;

                Console.WriteLine(investimento.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
