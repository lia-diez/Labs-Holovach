using System;
using System.Collections.Generic;
using Strlib;


namespace lab9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a few words, divided by whitespaces");
            string words = Console.ReadLine();
            Class1.RepeatSymbols(words);
            /*char[] arr = words.ToCharArray();
            List<char> symb = new List<char>();
            Class1.Letters(arr, symb);/**/
        }
    }
}
