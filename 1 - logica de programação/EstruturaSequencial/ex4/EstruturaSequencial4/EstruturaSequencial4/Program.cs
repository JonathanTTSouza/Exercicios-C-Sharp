using System;
using System.Globalization;

namespace EstruturaSequencial4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFun, horas;
            double valor, salario;

            numFun = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

            salario = (double)horas * valor;

            Console.WriteLine("Number: " + numFun);
            Console.WriteLine("Salary: $" + salario);
        }
    }
}
