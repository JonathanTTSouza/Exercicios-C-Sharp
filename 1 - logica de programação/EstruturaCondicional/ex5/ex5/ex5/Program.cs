using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ') ;

            double total;
            int codigo = int.Parse(valores[0]);
            int quantidade = int.Parse(valores[1]);

            if(codigo == 1)
            {
                total = quantidade * 4.00;
                Console.WriteLine("R$: " + total.ToString("F2"));
            }
            if (codigo == 2)
            {
                total = quantidade * 4.50;
                Console.WriteLine("R$: " + total.ToString("F2"));
            }
            if (codigo == 3)
            {
                total = quantidade * 5.00;
                Console.WriteLine("R$: " + total.ToString("F2"));
            }
            if (codigo == 4)
            {
                total = quantidade * 2.00;
                Console.WriteLine("R$: " + total.ToString("F2"));
            }
            if (codigo == 5)
            {
                total = quantidade * 1.50 ;
                Console.WriteLine("R$: " + total.ToString("F2"));
            }
        }
    }
}
