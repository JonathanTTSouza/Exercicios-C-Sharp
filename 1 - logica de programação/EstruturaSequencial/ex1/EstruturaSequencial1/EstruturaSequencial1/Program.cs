using System;

namespace EstruturaSequencial1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a, b, soma;

            Console.WriteLine("Digite numero 1: ");
            a = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite numero 2: ");
            b = decimal.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("A soma deu: " + soma);

        }
    }
}
