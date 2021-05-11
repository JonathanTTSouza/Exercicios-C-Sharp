using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("par");
            } else if( numero % 2 != 0)
            {
                Console.WriteLine("impar");
            }
        }
    }
}
