using System;
using System.Globalization;

namespace EstruturaSequencial6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, areaTri, areaCir, areaTra, areaQuad, areaRet, pi = 3.14159;
            
            Console.WriteLine("Digite valores para a, b e c: ");

            string[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);


            areaTri = (a * c )/ 2;
            areaCir = Math.Pow(c, 2.0) * pi;
            areaTra = ((a + b) * c) / 2;
            areaQuad = Math.Pow(b, 2.0);
            areaRet = a * b;

            Console.WriteLine("------------------------------");
            Console.WriteLine("Area do Triangulo Retangulo: " + areaTri.ToString("F3"));
            Console.WriteLine("Area do Circulo com raio c: " + areaCir.ToString("F3"));
            Console.WriteLine("Area do Trapezio com bases a e b, e altura c: " + areaTra.ToString("F3"));
            Console.WriteLine("Area do quadrado com lado b: " + areaQuad.ToString("F3"));
            Console.WriteLine("Area do Retangulo com lados a e b: " + areaRet.ToString("F3"));



        }
    }
}
