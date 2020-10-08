using System;

namespace Task5_Sem_03_EX_20_
{
    class Program
    {
        public static int[] FormMass(uint n)
        {
            Random rnd = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(10, 101);
            }
            return array;
        }
        public static void ArrayItemDouble(int[] array, int x)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == x)
                {
                    Array.Resize(ref array, array.Length + 1);
                    for (int j = array.Length - 1; j > i; j--)
                    {
                        array[j] = array[j - 1];
                    }
                    i++;
                }
            }
            Array.ForEach(array, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            uint n;
            int y;
            while (!uint.TryParse(Console.ReadLine(), out n) || !int.TryParse(Console.ReadLine(), out y) || y < 10 || y > 100) ;
            int[] array = FormMass(n);
            Array.ForEach(array, x => Console.Write($"{x} "));
            Console.WriteLine();
            ArrayItemDouble(array, y);
        }
    }
}
