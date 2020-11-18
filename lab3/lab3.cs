using System;

namespace lab3
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of x");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            int fac = 1;
            double eps = 0.0001;
            int k = 0;
            double el;
            double sum;
            for (int i = 1; i < n + 1; i++)
            {
                fac *= i;
            }

            el = Math.Pow((x / 2), n) / fac;
            sum = el;
            while (Math.Abs(el) > eps)
            {
                el = -1 * el * Math.Pow(x, 2) / (4 * (k + 1) * (k + n + 1));
                sum += el;
                k++;
            }

            Console.WriteLine("The sum is: {0:f4}", sum);
        }
    }
}