using System;

namespace Task7_Sem_04_EX_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1) ;
            int numberOfStrings = 0, sum = 0;
            for (int i = 1; sum < n; i++)
            {
                sum += i;
                numberOfStrings++;
            }
            int[][] array = new int[numberOfStrings][];
            for (int i = 0; i < numberOfStrings; i++)
            {
                Array.Resize(ref array[i], i + 1);
            }
            for (int i = 0; i < numberOfStrings; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = n;
                    n--;
                    if (n == -1)
                    {
                        break;
                    }
                    Console.Write($"{array[i][j],4}");
                }
                Console.WriteLine();
            }
        }
    }
}
