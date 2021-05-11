using System;
using System.Globalization;

namespace ex1
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return 2 * Altura + 2 * Largura;
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2.0) + Math.Pow(Largura, 2.0));
        }
        public override string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "PERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

    }
    
}
