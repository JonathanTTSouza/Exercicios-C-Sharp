using System;
using System.Globalization;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a altura e a largura do retangulo: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(ret);

        }
    }
}
