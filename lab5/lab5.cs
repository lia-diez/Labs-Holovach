using System;

namespace lab5
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int numb = int.Parse(Console.ReadLine());
            int n = numb;
            while (n > 9)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;
            }
            Console.WriteLine($"Digital root of the number is {n}");
        }
    }
}
