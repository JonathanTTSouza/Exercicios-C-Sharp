using System;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa pra simular rendimento de aplicação com juros de 3.36% mensais(aplicando valor inicial mensalmente)");

            Console.Write("Investimento: ");
            double investimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double investimentoMensal = investimento;

            Console.Write("Meses: ");
            int n = int.Parse(Console.ReadLine());

            investimento += investimento * 0.0336;

            Console.Write("Mês 1: " + investimento.ToString("F2", CultureInfo.InvariantCulture)
                    + " (sem aplicação: "
                    + investimentoMensal
                    + ")")
                   ;
            Console.WriteLine();
            

            for (int i = 1; i < n; i++)
            {
                investimento += (investimento * 0.0336) + investimentoMensal;
                
                Console.Write($"Mês {i + 1}: " + investimento.ToString("F2", CultureInfo.InvariantCulture)
                    + " (sem aplicação: "
                    + investimentoMensal * (i+1)
                    + ")")
                   ;
                Console.WriteLine();
            }
        }
    }
}
