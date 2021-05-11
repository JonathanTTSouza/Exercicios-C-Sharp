using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            valor = double.Parse(Console.ReadLine());

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("entre 0 e 25");
            }
            else
            if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("entre 25 e 50");
            }else
            if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("entre 50 e 75");
            }else
            if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("entre 75 e 100");
            }
            else
            {
                Console.WriteLine("Fora do Intervalo");
            }
        }
    }
}
