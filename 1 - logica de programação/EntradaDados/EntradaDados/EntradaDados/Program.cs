using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa?: ");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura(na mesma linha): ");
            string[] NomIdaAlt = Console.ReadLine().Split(' ');
            string ultNome = NomIdaAlt[0];
            int idade = int.Parse(NomIdaAlt[1]);
            double altura = double.Parse(NomIdaAlt[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto);
            Console.WriteLine(ultNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
