using System;

namespace exercicio_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;

            Console.WriteLine("numero conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("nome titular: ");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Quer colocar dinheiro? (s/n): ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S')
            {
                Console.WriteLine("Valor Deposito Inicial: ");
                double saldo = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numeroConta, nomeTitular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine(conta);

            Console.WriteLine("Adicionar dinheiro: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);

            Console.WriteLine(conta);

            Console.WriteLine("Retirar dinheiro: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);

            Console.WriteLine(conta);

        }
    }
}
