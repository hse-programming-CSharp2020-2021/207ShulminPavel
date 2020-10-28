using System;

namespace Task_2
{
    class Program
    {
        public static void Generate(int n)
        {
            int[][] pascal = new int[n][];
            for (int i = 0; i < pascal.Length; i++)
            {
                pascal[i] = new int[i + 1];
            }
            pascal[0][0] = 1;
            pascal[1][0] = 1;
            pascal[1][1] = 1;
            for (int i = 2; i < pascal.Length; i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    if (j != 0 && j != pascal[i].Length - 1)
                    {
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                    }
                    else
                    {
                        pascal[i][j] = 1;
                    }
                }
            }
            for (int i = 0; i < pascal.Length; i++)
            {
                for (int j = 0; j < pascal[i].Length; j++)
                {
                    Console.Write($"{pascal[i][j]} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 2)
            {
                Console.WriteLine("Введите другое n.");
            }
            Generate(n);
        }
    }
}
