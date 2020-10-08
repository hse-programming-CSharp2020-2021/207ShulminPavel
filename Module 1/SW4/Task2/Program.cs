using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = (i + 1) * (i + 1);
                Console.WriteLine(a[i]);
            }
        }
    }
}
