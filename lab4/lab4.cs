using System;

namespace lab4
{
    class Program
    {
        
        public static int Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double ai = (double) (i - 1) / (i + 1) + Math.Sin(Math.Pow((i - 1), 3) / (i + 1));
                if (ai > 0)
                    Console.Write($"{ai:f4} ");
            }

            return 0;
        }
    }
}