using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario sujeito = new Funcionario();
            double porcent;

            Console.Write("Nome: ");
            sujeito.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            sujeito.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            sujeito.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionario: " + sujeito);

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            porcent = double.Parse(Console.ReadLine());
            sujeito.AumentarSalario(porcent);
            Console.WriteLine("Dados atualizados: " + sujeito);
        }
    }
}
