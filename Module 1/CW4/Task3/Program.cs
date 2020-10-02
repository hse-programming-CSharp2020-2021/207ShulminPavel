using System;

namespace Task3
{
    class Program
    {
        public static int[] Generate(int[] x, int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(10, 50);
                Console.Write(x[i] + " ");
            }
            return x;
        }
        public static void Output(int[] x, int k)
        {
            for (int i = 0; i < k; i++)
            {
                Console.Write(x[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] a = new int[2*n];
            int[] b = new int[n];
            Generate(a, n);
            Console.WriteLine();
            Generate(b, n);
            Console.WriteLine();
            int k = n;
            for (int i = 0; i < n; i++)
            {
                if (b[i] % 2 == 0)
                {
                    a[k] = b[i];
                    k++;
                }
            }
            Output(a, k);
            Console.WriteLine();
        }
    }
}
