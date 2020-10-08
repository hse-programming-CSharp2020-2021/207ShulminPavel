using System;

namespace Task1
{
    class Program
    {
        public static void Generate(int n)
        {
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (i == j) ? 0 : (i < j) ? 1 : -1;
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;

            Generate(n);
        }
    }
}
