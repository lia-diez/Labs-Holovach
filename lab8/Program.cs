using System;
using LibDiamond;

namespace lab8
{
    class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter odd natural number");
            int n = int.Parse(Console.ReadLine());
            while (n % 2 == 0 || n<=0)
            {
                Console.WriteLine("Entered number is not correct\nEnter odd natural number");
                n = int.Parse(Console.ReadLine());
            }
            
            int[,] arr = new int[n, n];
            int[] elem = new int[n * n / 2 + 1];
            
            arr = Class1.InitArray(n);
            
            Class1.GenerDiamond(arr, elem, n);
            
            int max = Class1.MaxElem(elem, n);
            int sum = Class1.SumOfElem(elem, n);
        }
    }
}