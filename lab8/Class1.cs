using System;

namespace LibDiamond
{
    public class Class1
    {
        public static int[,] InitArray(int n)
        {
            Console.WriteLine("Random array is ");
            int [,] arr = new int[n,n];
            Random num = new Random();
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i,j] = num.Next(10, 100);
                    Console.Write($"{arr[i,j]}\t");
                }
                Console.Write("\n");
            }
            
            return arr;
        }
        
        public static void GenerDiamond(int[,] arr, int[] elem, int n)
        {
            int k = 0;
            int quantity = 0;
            int step = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= 2*quantity; j++)
                {
                    elem[k] = arr[i, n / 2 - quantity + j];
                    k++;
                }
                if (i == n / 2) step = -1;
                quantity += step;
            }
            
            Console.WriteLine("\nElements in the diamond are");
            for (int i = 0; i < n * n / 2 + 1; i++)
            {
                Console.Write($"{elem[i]}\t");
            }
        }

        public static int SumOfElem(int[] array, int n)
        {
            int sum = 0;
            for (int i = 0; i < n * n / 2 + 1; i++)
            {
                sum += array[i];
            }
            
            Console.WriteLine($"\nSum of elements is {sum}");
            return sum;
        }
        
        public static int MaxElem(int[] array, int n)
        {
            int maxEl = array[0];
            for (int i = 1; i < n * n / 2 + 1; i++)
            {
                if (maxEl < array[i]) 
                    maxEl = array[i];
            }
            
            Console.WriteLine($"\n\nMaximum element is {maxEl}");
            return maxEl;
        }
    }
}