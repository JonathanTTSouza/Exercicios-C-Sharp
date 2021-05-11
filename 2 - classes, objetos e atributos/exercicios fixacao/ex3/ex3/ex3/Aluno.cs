using System;
using System.Globalization;

namespace ex3
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double Media()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public string Verificacao()
        {
            if (Media() < 60)
            {
                return "Reprovado\n" +
                    "Faltou " + (60 - Media()).ToString("F2", CultureInfo.InvariantCulture);

            } else
            {
                return "Aprovado!";
            }
        }

    }
}
