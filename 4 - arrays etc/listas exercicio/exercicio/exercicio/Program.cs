using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered? ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Employee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salary: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id, nome, salario));
            }
            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int compararId = int.Parse(Console.ReadLine());

            Funcionario funcionario = lista.Find(x => x.Id == compararId);

            if (funcionario != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.AumentarSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Id não encontrado");
            }
            Console.WriteLine("Updated list of employees:");
            foreach(Funcionario obj in lista)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
