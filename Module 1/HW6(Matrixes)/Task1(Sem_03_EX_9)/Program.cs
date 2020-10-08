using System;

namespace Task1_Sem_03_EX_9_
{
    class Program
    {
        public static void ArrayHill(int[] arr)
        {
            int[] ans = new int[arr.Length];
            Array.Sort(arr);
            int help = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    ans[i / 2] = arr[i];
                }
                else
                {
                    ans[arr.Length - i + help] = arr[i];
                    help++;
                }
            }
            Array.ForEach(ans, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            uint N;
            while (!uint.TryParse(Console.ReadLine(), out N)) ;
            int[] arr = new int[N];
            for(int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(-10, 11);
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n");
            ArrayHill(arr);
        }
    }
}
