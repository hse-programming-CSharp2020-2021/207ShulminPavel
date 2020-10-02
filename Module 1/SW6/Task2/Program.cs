using System;

namespace Task2
{
    class Program
    {
        public static void GenerateMas(int N)
        {
            Random rnd = new Random();
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(-10, 11);
            }
            int m = 0;
            for (int k = 0; k < N; k++)
            {
                if (arr[k] % 2 == 1)
                {
                    arr[m++] = arr[k];
                }
            }
            if (m > 0)
            {
                Array.Resize(ref arr, m);
            }
            Array.ForEach(arr, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            GenerateMas(N);
        }
    }
}
