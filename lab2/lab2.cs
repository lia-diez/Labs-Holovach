using System;

namespace lab5
{
    class Program
    {
        private static int Main(string[] args)
        {
            Console.WriteLine("the sum is {0}", SumOfProgression(0, 50));
            return 0;
        }

        private static float SumOfProgression(float sum, float el)
        {
            sum += el;
            el /= 2;
            //Console.WriteLine($"{sum} {el}");
            if (el > 1) sum = SumOfProgression(sum, el);
            return sum;
        }
    }
}

