using System;

namespace Task7
{
    class Program
    {
        public static string Method1(double a)
        {
            return $"Целая часть: {(int)a} \nДробная часть: {a - (double)(int)a}\n";
        }
        public static string Method2(double a)
        {
            if (a < 0)
            {
                return "Квадрат числа: " + Math.Pow(a, 2.0);
            }
            else
            {
                return $"Квадрат числа: {Math.Pow(a, 2.0)} \nКорень из числа: {Math.Sqrt(a)}";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double a;
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(Method1(a) + Method2(a));
        }
    }
}
