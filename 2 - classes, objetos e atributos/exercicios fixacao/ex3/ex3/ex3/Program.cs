using System;
using System.Globalization;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno pessoa = new Aluno();

            Console.Write("Nome do Aluno: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            pessoa.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = pessoa.Media();

            Console.WriteLine("Nota final: " + media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(pessoa.Verificacao()); 

        }
    }
}
