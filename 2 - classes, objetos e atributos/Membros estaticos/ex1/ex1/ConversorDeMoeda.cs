using System;
using System.Collections.Generic;
using System.Text;

namespace ex1
{
    class ConversorDeMoeda
    {
        public static double IoF = 6;
            public static double ConverterReais(double cotacao, double quantidadeDolar)
        {
            double total = cotacao * quantidadeDolar;
            return total + (total * IoF / 100);
        }

    }
}
