using System;

namespace Task1_exercise_4_
{
    class Program
    {
        public static int[] GetMass(int x)
        {
            int size = 1;
            int[] array = new int[size];
            array[0] = x;
            for (int i = 0; array[i] != 1; i++)
            {
                size++;
                Array.Resize(ref array, size);
                array[i + 1] = array[i] % 2 == 0 ? array[i] / 2 : (3 * array[i] + 1);
            }
            return array;
        }
        public static void OutPut(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"[{i}] = {array[i]}, ");
                if ((i + 1) % 5 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            int firstElement;
            while (!int.TryParse(Console.ReadLine(), out firstElement) || firstElement <= 0) ;
            OutPut(GetMass(firstElement));
        }
    }
}
