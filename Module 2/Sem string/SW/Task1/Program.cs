using System;
using System.Collections.Generic;

namespace Task1
{
    class Program
    {

        public static string DeleteSpaces(string str)
        {
            string[] arr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return String.Join(' ', arr);
        }

        public static int WordsMoreThanFour(string str)
        {
            int sum = 0;
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > 4)
                {
                    sum++;
                }
            }
            return sum;
        }

        public static int Vowels(string str)
        {
            int num = 0;
            string[] arr = str.Split(' ');
            List<char> vowels = new List<char>() { 'а', 'я', 'у', 'ю', 'э', 'е', 'о', 'ё', 'ы', 'и' };
            for (int i = 0; i < arr.Length; i++)
            {
                if (vowels.Contains(arr[i][0]))
                {
                    num++;
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            Console.WriteLine(DeleteSpaces(str));
            Console.WriteLine(WordsMoreThanFour(DeleteSpaces(str)));
            Console.WriteLine(Vowels(DeleteSpaces(str)));
        }
    }
}
