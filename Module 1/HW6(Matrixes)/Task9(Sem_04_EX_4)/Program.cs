using System;

namespace Task9_Sem_04_EX_4_
{
    class Program
    {
        public static int Det(int[,] a, int n)
        {
            int det = 0;
            if (n == 2)
            {
                det = a[0, 0] * a[1, 1] - a[1, 0] * a[0, 1];
            }
            if (n == 3)
            {
                det = (a[0, 0] * a[1, 1] * a[2, 2]) + (a[0, 1] * a[1, 2] * a[2, 0]) + (a[1, 0] * a[2, 1] * a[0, 2]) 
                    - (a[0, 2] * a[1, 1] * a[2, 0]) - (a[0, 1] * a[1, 0] * a[2, 2]) - (a[0, 0] * a[1, 2] * a[2, 1]);
            }
            return det;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите размер  матрицы определитель которой вы хотите посчитать(2 или 3).");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) && (n != 2 || n != 3)) ;
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rnd.Next(1, 11);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(Det(matrix, n));
        }
    }
}
