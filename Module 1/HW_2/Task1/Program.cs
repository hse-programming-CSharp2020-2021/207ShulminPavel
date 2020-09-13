using System;

namespace Task1
{
    class Program
    {
        public static double Function(double x)
        {
            return 12 * x * x * x * x + 9 * x * x * x - 3 * x * x + 2 * x - 4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            double x;
            double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(Function(x).ToString("F3"));
        }
    }
}
