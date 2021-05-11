using ExercicioFixacao.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path");
            string sourceFilePath = Console.ReadLine();
           
            try
            {
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');

                        string productName = fields[0];
                        double productPrice = double.Parse(fields[1]);
                        int productQuantity = int.Parse(fields[2]);

                        Produto produto = new Produto(productName, productPrice, productQuantity);

                        sw.WriteLine(produto.Name + "," + produto.TotalPrice().ToString("F2", CultureInfo.InvariantCulture));
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
            }
        }
    }
}
