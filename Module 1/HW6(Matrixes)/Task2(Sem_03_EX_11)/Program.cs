using System;

namespace Task2_Sem_03_EX_11_
{
    class Program
    {
        public static void Fill(uint n)
        {
            int[] array = new int[n];
            array[0] = 0;
            array[1] = 1;
            for (int i = 2; i < n; i++)
            {
                array[i] = 34 * array[i - 1] - array[i - 2] + 2;
            }
            Array.ForEach(array, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            Random rns = new Random();
            uint n;
            while (!uint.TryParse(Console.ReadLine(), out n) || n < 3) ;
            Fill(n);
            Console.WriteLine();
        }
    }
}
