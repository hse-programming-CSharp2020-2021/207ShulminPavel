using System;

namespace Task3_Sem_03_EX_13_
{
    class Program
    {
        public static void OutPut(uint n, uint k)
        {
            int[] array = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-10, 11);
            }
            Console.Write($"{array[0]} ");
            for (uint i = k; i < n; i += k)
            {
                Console.Write($"{array[i]} ");
            }
        }
        static void Main(string[] args)
        {
            uint n, k;
            while (!uint.TryParse(Console.ReadLine(), out n) || !uint.TryParse(Console.ReadLine(), out k) || n <= k) ;
            OutPut(n, k);
        }
    }
}
