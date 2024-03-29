﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace MetodosAbstratos.Entities
{
    abstract class Pessoa
    {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }
        public Pessoa()
        {
        }
        public Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }
        public abstract double CalculoImposto();
        public abstract override string ToString();
    }
}
