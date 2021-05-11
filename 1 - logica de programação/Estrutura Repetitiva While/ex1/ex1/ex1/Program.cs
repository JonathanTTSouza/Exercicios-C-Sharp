using System;
using System.Net.Mail;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite senha: ");
            string senha = Console.ReadLine();

            while (senha != "2002")
            {
                Console.WriteLine("Senha Incorreta");
                Console.WriteLine("Digite senha: ");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Senha correta");
        }
    }
}
