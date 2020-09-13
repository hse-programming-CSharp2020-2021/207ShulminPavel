using System;

namespace Task4
{
    class Program
    {
        public static int Reverse(int a)
        {
            int b = 0;
            for (int i = 0; i < 4; i++)
            {
                b = b * 10 + a % 10;
                a /= 10;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите четырёхзначное число");
            int.TryParse(Console.ReadLine(), out a);
            if (a < 1000 || a > 9999)
            {
                Console.WriteLine("Введённое число не соответствует требованиям");
            }
            else
            {
                Console.WriteLine(Reverse(a));
            }

        }
    }
}
