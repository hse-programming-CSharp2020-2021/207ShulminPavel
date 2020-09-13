using System;

namespace Task6
{
    class Program
    {
        public static void Games(double b, int p)
        {
            b = b * p / 100;
            Console.WriteLine(b.ToString("F3"));
        }
        static void Main(string[] args)
        {
            double b;
            int p;
            Console.WriteLine("Введите бюджет пользователя и процент бюджета, выделенного на компьютерные игры");
            if (double.TryParse(Console.ReadLine(), out b) && int.TryParse(Console.ReadLine(), out p))
            {
                Games(b, p);
            }
            else
            {
                return;
            }
        }
    }
}
