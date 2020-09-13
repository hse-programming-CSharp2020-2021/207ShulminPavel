using System;

namespace Task3
{
    class Program
    {
        public static string Roots(double A, double B, double C)
        {
            double D = B * B - 4 * A * C;
            double x1, x2;
            x1 = (-B + Math.Sqrt(D)) / 2 * A;
            x2 = (-B - Math.Sqrt(D)) / 2 * A;
            return $"Первый корень {x1} второй корень {x2}";
        }
        static void Main(string[] args)
        {
            double A, B, C;
            Console.WriteLine("Введите три числа, первое из них не должно быть 0");
            double.TryParse(Console.ReadLine(), out A);
            double.TryParse(Console.ReadLine(), out B);
            double.TryParse(Console.ReadLine(), out C);
            if (A == 0)
            {
                Console.WriteLine("Введённые числа не соответствуют требованиям");
            }
            else
            {
                if (B * B - 4 * A * C < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else
                {
                    Console.WriteLine(Roots(A, B, C));
                }
            }
        }
    }
}
