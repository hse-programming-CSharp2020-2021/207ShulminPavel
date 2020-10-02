using System;

namespace Task2_exercise_6_
{
    class Program
    {
        public static int[] Compression(ref int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if ((array[i] + array[i + 1]) % 3 == 0)
                {
                    array[i] *= array[i + 1];
                    for (int j = i + 1; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    Array.Resize(ref array, array.Length - 1);
                }
            }
            return array;
        }
        public static int NumberOfCompression(int n, int n1)
        {
            return n - n1;
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n)) ;
            Random rand = new Random();
            int[] array = new int[n];
            Console.Write("Before: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-10, 11);
                Console.Write(array[i] + " ");
            }
            Compression(ref array);
            Console.WriteLine($"\nCompress {NumberOfCompression(n, array.Length)} times");
            Console.Write("After: ");
            Array.ForEach(array, x => Console.Write($"{x} "));
        }
    }
}
