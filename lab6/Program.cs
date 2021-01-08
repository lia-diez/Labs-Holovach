using System;

namespace lab6
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a, b, c;
            a = RandNum();
            b = RandNum();
            c = RandNum();
            Console.WriteLine($"Numbers are {a}, {b}, {c}");
            int sum = SumOfDigits(a, b, c);
            Console.WriteLine($"The sum of first digits of numbers is {sum}");
        }

        private static int SumOfDigits(int a, int b, int c)
        {
            int sum = FirstDigit(a) + FirstDigit(b) + FirstDigit(c);
            return sum;
        }

        private static int FirstDigit(int n)
        {
            int a = (int)Math.Floor(Math.Log10(n + 0.5));
            double digit = n / Math.Pow(10, a);
            return (int)digit;
        }

        private static int RandNum()
        {
            Random numb = new Random();
            int n = numb.Next(1, 10000);
            return n;
        }
    }
}