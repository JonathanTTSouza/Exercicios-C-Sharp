using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Registro
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Registro(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
    
}