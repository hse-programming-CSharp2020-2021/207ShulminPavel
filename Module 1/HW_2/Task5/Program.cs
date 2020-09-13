using System;

namespace Task5
{
    class Program
    {
        public static bool Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return false;
            }
            double max;
            max = a > b ? (a > c ? a : c) : (b > c ? b : c);
            if (a + b + c - max > max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Введите три числа");
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            if (Triangle(a, b, c))
            {
                Console.WriteLine("Треугольник существует");
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
            }
        }
    }
}
