using System;
using System.Globalization;

namespace EstruturaSequencial5
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo1, numeroPecas1, codigo2, numeroPecas2;
            double valor1, valor2, soma;

            codigo1 = int.Parse(Console.ReadLine());
            numeroPecas1 = int.Parse(Console.ReadLine());
            valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            codigo2 = int.Parse(Console.ReadLine());
            numeroPecas2 = int.Parse(Console.ReadLine());
            valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = numeroPecas1 * valor1 + numeroPecas2 * valor2;

            Console.WriteLine(soma.ToString("F2"));


        }
    }
}
