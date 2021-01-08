using System;

namespace lab7
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            double [] array = new double[n];
            array = InitArray(n);
            
            int maxIn = 0, minIn = 0;
            FindValues(array, ref maxIn, ref minIn);
            Console.WriteLine($"\nMinimal positive element is {array[minIn]:f2}, the index of this element is {minIn}");
            Console.WriteLine($"Maximal element is {array[maxIn]:f2}, the index of this element is {maxIn}");
            
            array = Swap(array, maxIn, minIn);
        }
        

        private static double RandNum()
        {
            Random num = new Random();
            double numb = num.Next(-50, 99)+num.NextDouble();
            return numb;
        }

        private static double[] InitArray(int n)
        {
            Console.WriteLine("Random array is ");
            double [] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = RandNum();
                Console.Write($"{arr[i]:f2}  ");
            }
            
            return arr;
        }

        private static void FindValues(double[] arr, ref int maxI, ref int minI)
        {
            double maxNum, minNum;
            maxNum = -100;
            minNum = 1000;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    if (arr[i] > maxNum)
                    {
                        maxNum = arr[i];
                        maxI = i;
                    }

                    if (arr[i] < minNum)
                    {
                        minNum = arr[i];
                        minI = i;
                    }
                }
            }
        }

        private static double[] Swap(double[] array, int maxIn, int minIn)
        {
            double elem = array[maxIn];
            array[maxIn] = array[minIn];
            array[minIn] = elem;
            Console.WriteLine("Changed array is");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]:f2}  ");
            }
            return array;
        }
    }
}