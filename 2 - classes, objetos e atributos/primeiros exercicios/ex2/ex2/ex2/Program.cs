using System;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            double media;

            Console.WriteLine("Digite dados da primeira pessoa: ");
            p1.Nome = Console.ReadLine();
            p1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite dados da segunda pessoa: ");
            p2.Nome = Console.ReadLine();
            p2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
