using System;

namespace Arrays_ex_2
{
    class Program
    {
        public static int[][] FillTheArray(int n)
        {
            int[][] result = new int[n][];
            for (int i = 0; i < n; i++)
            {
                result[i] = new int[n];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = (i + j + 1) % n;
                    if (result[i][j] == 0)
                    {
                        result[i][j] = n;
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1) ;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(String.Format("{0, 3}", FillTheArray(n)[i][j]));
                }
                Console.WriteLine();
            }
        }
    }
}
