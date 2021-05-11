using System;
using System.Globalization;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar?: ");
            double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dolares você vai comprar?: ");
            double quantidadeDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Valor a ser pago em reais: " + ConversorDeMoeda.ConverterReais(cotacaoDolar, quantidadeDolar).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
