using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0, gasolina = 0, diesel = 0, codigo;

            Console.WriteLine("Digite código: ");
            Console.WriteLine("1- Alcool");
            Console.WriteLine("2- Gasolina");
            Console.WriteLine("3- Diesel");
            Console.WriteLine("4- Fim");

            codigo = int.Parse(Console.ReadLine());

            while ( codigo !=4 )
            {
                if (codigo == 1)
                {
                    Console.WriteLine("Alcool selecionado. Digite outro código: ");
                    alcool++;
                    codigo = int.Parse(Console.ReadLine());
                } else if (codigo == 2)
                {
                    Console.WriteLine("Gasolina selecionado. Digite outro código: ");
                    gasolina++;
                    codigo = int.Parse(Console.ReadLine());
                }else if (codigo == 3)
                {
                    Console.WriteLine("Diesel selecionado. Digite outro código: "); 
                    diesel++;
                    codigo = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Codigo invalido, digite novamente: ");
                    codigo = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Alcool: "+ alcool + "\nGasolina: " + gasolina + "\nDiesel: " + diesel);
        }
    }
}
