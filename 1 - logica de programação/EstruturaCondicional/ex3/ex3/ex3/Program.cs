using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);

            if (a > b)
            {
                if(a%b == 0)
                {
                    Console.WriteLine("Multiplo");
                } else if (a % b != 0)
                {
                    Console.WriteLine("Não Multiplo");
                }
            } else if (a < b)
            {
                if (b % a == 0)
                {
                    Console.WriteLine("Multiplo");
                } else if (b % a != 0)
                {
                    Console.WriteLine("Não Multiplo");
                }
            }
        }
    }
}
