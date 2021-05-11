using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numIn = 0, numOut = 0, numero;

            Console.WriteLine("Digite quantos valores serão inseridos: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite numero " + i + ":");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 10 && numero <= 20)
                {
                    numIn++;
                } else
                {
                    numOut++;
                }
            }
            Console.WriteLine("In: " + numIn + "\nOut: " + numOut);
        }
    }
}
