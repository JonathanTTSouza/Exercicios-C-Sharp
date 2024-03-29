﻿using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro[] vect = new Registro[10];

            Console.WriteLine("Quantos quartos serão alugados?");
            int n = int.Parse(Console.ReadLine());
                        
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Aluguel #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Registro(nome, email);
            }
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
