using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, y, d;
            Console.WriteLine("Imprime números del x hasta y");
            Console.WriteLine("Cuanto vale x?");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuanto vale y?");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("De cuanto en cuanto va a hacer?");
            d = Convert.ToInt32(Console.ReadLine());
            if (n > y)
            {
                for (int i = n; i > y; i -= d)
                {
                    Console.WriteLine("i = " + i);
                }
            }
            else
            {
                for (int i = n; i < y; i += d)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
