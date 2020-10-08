using System;

namespace Task2
{
    class Program
    {
        public static void OutPut(int n)
        {
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(-10, 11);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            int help = 0;
            for (int i = 0; i < n; i++)
            {
                if (i == n - 1) break;
                if (arr[i] < 0)
                {
                    help = arr[i];
                    for (int j = i; j < n - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    
                    i--;
                    arr[n - 1] = help;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0) ;

            OutPut(n);
        }
    }
}
