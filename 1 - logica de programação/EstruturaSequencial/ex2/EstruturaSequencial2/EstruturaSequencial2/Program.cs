using System;

namespace EstruturaSequencial2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.WriteLine("Digite o tamanho do raio: ");
            raio = double.Parse(Console.ReadLine());

            area = raio * raio * pi;

            Console.WriteLine("A area do circulo é de: ");
            Console.WriteLine(area.ToString("F4"));
        }
    }
}
