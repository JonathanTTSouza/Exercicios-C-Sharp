using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetodosAbstratos.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastosComSaude { get; set; }
        public PessoaFisica()
        {
        }
        public PessoaFisica(string nome, double rendaAnual, double gastosComSaude) : base(nome, rendaAnual)
        {
            GastosComSaude = gastosComSaude;
        }
        public override double CalculoImposto()
        {

            if (RendaAnual < 20000)
            {
                double imposto = RendaAnual * 0.15 - GastosComSaude * 0.50;
                return imposto;
            }
            else
            {
                double imposto = RendaAnual * 0.25 - GastosComSaude * 0.50;
                return imposto;
            }

        }
        public override string ToString()
        {
            return Nome + " : $ " + CalculoImposto().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}


