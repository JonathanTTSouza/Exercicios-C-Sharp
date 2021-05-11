using MetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();

            Console.Write("Enter the number of tax payers: ");
            double n = double.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'i')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();

                    Console.Write("Anual income:");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Health expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Pessoa pessoa = new PessoaFisica(name, anualIncome, healthExpenditures);
                    lista.Add(pessoa);
                }
                if (ch == 'c')
                {
                    Console.Write("Name:");
                    string name = Console.ReadLine();

                    Console.Write("Anual income:");
                    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Number of employees:");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    Pessoa pessoa = new PessoaJuridica(name, anualIncome, numberOfEmployees);
                    lista.Add(pessoa);
                }
            }
            Console.WriteLine("TAXES PAID:");
            foreach (Pessoa pessoa in lista)
            {
                Console.WriteLine(pessoa);
            }

            Console.Write("TOTAL TAXES: $ ");

            double sum = 0;
            foreach (Pessoa pessoa in lista)
            {
                sum += pessoa.CalculoImposto();
            }

            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
