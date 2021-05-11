using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFixacao.Entities
{
    class Produto
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Produto()
        {
        }

        public Produto(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public double TotalPrice()
        {
            return Price * Quantity;
        }

    }
}
