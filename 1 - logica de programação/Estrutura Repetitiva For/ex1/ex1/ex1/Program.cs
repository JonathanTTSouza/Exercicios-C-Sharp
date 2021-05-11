using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("digite valor de x(entre 1 e 1000): ");
            x = int.Parse(Console.ReadLine());

            if (x < 1 || x > 1000)
            {
                Console.WriteLine("Valor especificado não valido, tente novamente");
            }
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
