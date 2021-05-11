using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            } else if(numero >= 0)
            {
                Console.WriteLine("Positivo");
            }
        }
    }
}
