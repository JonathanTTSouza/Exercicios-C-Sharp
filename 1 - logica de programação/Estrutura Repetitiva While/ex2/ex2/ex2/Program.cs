using System;
using System.Security.Cryptography.X509Certificates;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores para pontos x e y");
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    Console.WriteLine("digite outros valores: ");

                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                } else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    Console.WriteLine("digite outros valores: ");

                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    Console.WriteLine("digite outros valores: ");

                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    Console.WriteLine("digite outros valores: ");

                    valores = Console.ReadLine().Split(' ');

                    x = int.Parse(valores[0]);
                    y = int.Parse(valores[1]);
                }
            }

        }
    }
}
