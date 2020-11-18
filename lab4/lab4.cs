using System;

namespace lab3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            double ai;
            for (int i = 1; i <= n; i++)
            {
                ai = (float) (i - 1) / (i + 1) + Math.Sin(Math.Pow((i - 1), 3) / (i + 1));
                if (ai > 0)
                {
                    Console.WriteLine("ai is {0:f4}", ai);
                }
            }
        }
    }
}