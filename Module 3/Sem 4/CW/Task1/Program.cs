using System;

namespace Task1
{
    delegate double Del(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Del del = null;
            int x = int.Parse(Console.ReadLine());
            del += x =>
            {
                double sum = 0;
                double proizv = 1;
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= 5; j++)
                    {
                        proizv *= i * x / j;
                    }
                    sum += proizv;
                    proizv = 1;
                }
                return sum;
            };
            Console.WriteLine(del?.Invoke(x));
        }
    }
}
