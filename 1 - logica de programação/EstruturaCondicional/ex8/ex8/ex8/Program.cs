using System;
using System.Globalization;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite salario: ");

            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double IR;

            if (salario >= 0.00 && salario <= 2000.00)
            {
                IR = 0.00;
                Console.WriteLine("Isento de impostos");
            }
            else if (salario > 2000.00 && salario <= 3000.00)
            {
                IR = (salario - 2000.00) * 0.08;
                Console.WriteLine(IR);
            }
            else if (salario > 3000.00 && salario <= 4500.00)
            {
                IR = (salario - 3000.00) * 0.18 + 1000 * 0.08;
                Console.WriteLine("R$: " + IR);

            }else if ( salario > 4500.00)
            {
                IR = (salario - 4500.00) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
                Console.WriteLine("R$" + IR.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
