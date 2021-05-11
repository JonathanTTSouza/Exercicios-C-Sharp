using System;
using System.Xml;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaIni, horaFin, resultado;
            string[] valores = Console.ReadLine().Split(' ');

            horaIni = int.Parse(valores[0]);
            horaFin = int.Parse(valores[1]);
            
            if(horaIni < horaFin)
            {
                resultado = horaFin - horaIni;
                Console.WriteLine(resultado);
            } else
            {
                resultado = 24 - horaIni + horaFin;
                Console.WriteLine(resultado);
            }
        }
    }
}
