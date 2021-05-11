using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade)
            {
                Console.WriteLine("pessoa mais velha: " + x.Nome);
            }
            else
            {
                Console.WriteLine("pessoa mais velha: " + y.Nome);
            }

        }
    }
}
