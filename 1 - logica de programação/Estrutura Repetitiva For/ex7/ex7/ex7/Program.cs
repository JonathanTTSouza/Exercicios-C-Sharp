using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine(i + " " + Math.Pow(i, 2.0)+ " "+ Math.Pow(i, 3.0));
            }
        }
    }
}
