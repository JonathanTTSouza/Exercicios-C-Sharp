using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double divisao;
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i<= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                double a = double.Parse(valores[0]);
                double b = double.Parse(valores[1]);

                if (b == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {

                    divisao = a / b;

                    Console.WriteLine(divisao);
                }
            }
        }
    }
}
