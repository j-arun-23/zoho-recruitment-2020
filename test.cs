using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void PrintWords(string input)
        {
            string inputVal = input;
            int midValue = inputVal.Length / 2;

            //Store the string in reverse
            string val2 = inputVal.Substring(midValue);
            string val3 = inputVal.Substring(0, midValue);
            string reverseWord = val2 + val3;
            int inputLength = reverseWord.Length;

            for (int i = 0; i < inputLength; i++)
            {
                for (int j = 1; j < inputLength - i; j++)
                {
                    Console.Write("  ");
                }

                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(reverseWord[k] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void Main()
        {
            PrintWords("PASTE");            
        }
    }
}
