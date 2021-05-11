using exercicio_fixacao.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Transactions;

namespace exercicio_fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> listProduct = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new Product(name, price);
                    listProduct.Add(product);
                }
                else if (ch == 'u')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date(DD/ MM / YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(name, price, manufactureDate);
                    listProduct.Add(product);
                }
                else if (ch == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Product product = new ImportedProduct(name, price, customFee);
                    listProduct.Add(product);
                }
            }
            Console.WriteLine("PRICE TAGS");
            foreach (Product product in listProduct)
            {
                Console.WriteLine(product.PriceTag());
            }

        }
    }
}
