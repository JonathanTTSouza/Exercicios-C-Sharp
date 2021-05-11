using System;
using System.Globalization;

namespace ex3
{
    class Program
    {
        static double mediaPond(double x, double y, double z)
        {
            double m = ((x * 2) + (y * 3) + (z * 5)) / 10;
            return m;
        }
        static void Main(string[] args)
        {
            double resultado;
            Console.WriteLine("Numero caso de teste: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("digite 3 valores reais: ");
                string[] valores = Console.ReadLine().Split(' ');

                double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

                resultado = mediaPond(a, b, c);

                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
