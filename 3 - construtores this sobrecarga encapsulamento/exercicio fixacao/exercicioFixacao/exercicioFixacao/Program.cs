using System;
using System.Dynamic;
using System.Globalization;

namespace exercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial?(s/n)?: ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Valor do depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numero, titular, saldo);
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valorDeposito);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorSaque);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(conta);
            
        }
    }
}
