using System;
using System.Net.Http.Headers;

namespace Task_1
{
    class Program
    {
        public static int[] Primes(int[] sequence)
        {
            int[] simple = new int[0];
            for (int i = 0; i < sequence.Length; i++)
            {
                int k = 0;
                for (int j = 1; j < sequence[i]; j++)
                {
                    if (sequence[i] % j == 0)
                    {
                        k++;
                    }
                }
                if (k == 1)
                {
                    Array.Resize(ref simple, simple.Length + 1);
                    simple[simple.Length - 1] = sequence[i];
                }
            }
            return simple;
        }
        public static bool IsNonDecreasing(int[] sequence, out int min)
        {
            min = int.MaxValue;
            bool key = true;
            if (sequence[0] < min)
            {
                min = sequence[0];
            }
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] < sequence[i - 1])
                {
                    key = false;
                }
                if (sequence[i] < min)
                {
                    min = sequence[i];
                }
            }
            return key;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10000) ;
            int[] array = new int[n];
            Console.Write("исходная последовательность: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 101);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("количество простых элементов: " + Primes(array).Length);
            Console.Write("простые элементы массива: ");
            Array.ForEach(Primes(array), x => Console.Write($"{x} "));
            Console.WriteLine();
            Console.WriteLine("неубывающая ли последовательность: " + IsNonDecreasing(array, out int min));
            Console.WriteLine("минимальный элемент последовательности: " + min);
        }
    }
}
