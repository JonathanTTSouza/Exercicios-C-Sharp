using System;
using System.Collections.Generic;

namespace ExercicioFixacao.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> ListInstallment { get; set; }

        public Contract(int number, DateTime date, double totalValue, List<Installment> listInstallment)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            ListInstallment = listInstallment;
        }
    }
}
