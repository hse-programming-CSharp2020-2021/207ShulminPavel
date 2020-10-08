using System;

namespace Task8_Sem_04_EX_3_
{
    class Program
    {
        public static void OutPut(char[][] array, int n)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (j + i >= n / 2)
                    {
                        array[i][j] = '*';
                    }
                    else
                    {
                        array[i][j] = ' ';
                    }
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n % 2 == 0) ;
            char[][] array = new char[(n + 1) / 2][];
            for (int i = 0; i < array.Length; i++)
            {
                Array.Resize(ref array[i], n / 2 + i + 1);
            }
            OutPut(array, n);
        }
    }
}
