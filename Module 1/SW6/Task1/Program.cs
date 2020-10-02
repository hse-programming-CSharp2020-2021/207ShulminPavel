using System;

namespace Task2
{
    class Program
    {
        public static void Method(int N)
        {
            int memory = N;
            int col = 0;
            while (memory > 0)
            {
                col++;
                memory /= 10;
            }
            char[] arr = new char[col];
            for (int i = col - 1; N > 0; i--)
            {
                arr[i] = (char)(N % 10 + '0');
                N /= 10;
            }
            Array.ForEach(arr, x => Console.Write($"{x} "));
        }
        static void Main(string[] args)
        {
            int N;
            N = int.Parse(Console.ReadLine());
            Method(N);
        }
    }
}