using System;

namespace Task6_Sem_04_EX_1_
{
    class Program
    {
        public static int[,] FillingTheArray(int n)
        {
            int[,] matrix = new int[n, n];
            int i = 1, j, k, p = n / 2;
            for (k = 1; k <= p; k++)
            {
                for (j = k - 1; j < n - k + 1; j++)
                {
                    matrix[k - 1, j] = i++;
                }
                for (j = k; j < n - k + 1; j++)
                {
                    matrix[j, n - k] = i++;
                }
                for (j = n - k - 1; j >= k - 1; j--)
                {
                    matrix[n - k, j] = i++;
                }
                for (j = n - k - 1; j >= k; j--)
                {
                    matrix[j, k - 1] = i++;
                }
            }
            if (n % 2 == 1)
            {
                matrix[p, p] = n * n;
            }
            return matrix;
        }
        public static void OutPut(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1) ;
            OutPut(FillingTheArray(n), n);
        }
    }
}
