using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double CalculoImposto()
        {
            if (NumeroFuncionarios > 10)
            {
                double imposto = RendaAnual * 0.14;
                return imposto;
            }
            else
            {
                double imposto = RendaAnual * 0.16;
                return imposto;
            }
        }
        public override string ToString()
        {
            return Nome + " : $ " + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
