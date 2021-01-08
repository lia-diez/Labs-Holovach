using System;
using System.Collections.Generic;

namespace Strlib
{
    public class Class1
    {
        public static void RepeatSymbols(string wordsWithSpaces)
        {
            int repeatSymb = 0;
            string[] words = wordsWithSpaces.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Words that have equal first and last letter are ");
            for (int i = 0; i < words.Length; i++)
            {
                char[] letters = words[i].ToCharArray();
                if (letters[0] == letters[letters.Length-1])
                {
                    Console.Write($"{words[i]} ");
                    repeatSymb++;
                }
            }
            Console.WriteLine($"\nThe number of this words is {repeatSymb}");
        }
        public static void Letters (char[] arr, List<char> symb)
        {
            int lenght = arr.Length;
            bool isNotWhiteSpace;
            for (int i = 0; i < lenght; i++)
            {
                if (arr[i] != ' ')
                {
                    symb.Add(arr[i]);
                    isNotWhiteSpace = true;
                    while (isNotWhiteSpace)
                    {
                        i += 1;
                        if (i == lenght - 1 && arr[i] != ' ')
                        {
                            symb.Add(arr[i]);
                            isNotWhiteSpace = false;
                        }
                        else if (arr[i] == ' ')
                        {
                            symb.Add(arr[i-1]);
                            isNotWhiteSpace = false;
                        }
                    }
                }
            }
            Console.Write("Array with first and last letters of the words is");
            for (int i = 0; i < symb.Count; i++)
            {
                Console.Write($" {symb[i]}");
            }
            
            CountWords(symb);
        }

        public static void CountWords(List<char> symb)
        {
            int countWords = 0;
            
            Console.Write("\nEqual first and last letters are");
            for (int i = 0; i < symb.Count; i+=2)
            {
                for (int j = 0; j < symb.Count; j+=2)
                {
                    if (symb[i] == symb[j] && i != j)
                    {
                        if (symb[i + 1] == symb[j + 1])
                        {
                            countWords++;
                        }
                    }
                }
            }
            
            Console.WriteLine($"\nThe number of this words is {countWords/2}");
        }
    }
}
