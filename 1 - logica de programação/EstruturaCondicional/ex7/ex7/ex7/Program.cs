using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double coordenadaX = double.Parse(valores[0]);
            double coordenadaY = double.Parse(valores[1]);

            if (coordenadaX == 0 && coordenadaY == 0)
            {
                Console.WriteLine("Origem");
            } else if (coordenadaX > 0 && coordenadaY > 0)
            {
                Console.WriteLine("Q1");
            } else if (coordenadaX > 0 && coordenadaY < 0)
            {
                Console.WriteLine("Q4");
            } else if (coordenadaX < 0 && coordenadaY > 0)
            {
                Console.WriteLine("Q2");
            } else if (coordenadaX < 0 && coordenadaY < 0)
            {
                Console.WriteLine("Q3");
            }
            if (coordenadaX == 0)
            {
                Console.WriteLine("Eixo x");
            }
            if(coordenadaY == 0)
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}
