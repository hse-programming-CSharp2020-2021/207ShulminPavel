using System;

namespace Task4_Sem_03_EX_16_
{
    class Program
    {
        public static void Search(int[] array)
        {
            int min = 11, minInd = -1;
            int max = -11, maxInd = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minInd = i;
                }
                if (array[i] > max)
                {
                    max = array[i];
                    maxInd = i;
                }
            }
            Console.WriteLine($"{minInd} - индекс минимального элемента.");
            Console.WriteLine($"{minInd + maxInd} - сумма индексов минимального и максимального элементов массива.");
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            uint n;
            while (!uint.TryParse(Console.ReadLine(), out n)) ;
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 11);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Search(array);
        }
    }
}
