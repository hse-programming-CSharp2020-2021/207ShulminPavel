using System;

namespace Task2
{
    class Program
    {
        public static int Number(int a)
        {
            int a1 = a / 100, a2 = a / 10 % 10, a3 = a % 10;
            int min, mid, max;
            min = a1 < a2 ? (a1 < a3 ? a1 : a3) : (a2 < a3 ? a2 : a3);
            max = a1 > a2 ? (a1 > a3 ? a1 : a3) : (a2 > a3 ? a2 : a3);
            mid = a1 + a2 + a3 - min - max;
            return max * 100 + mid * 10 + min;
        }
        static void Main(string[] args)
        {
            int P;
            Console.WriteLine("Введите трёхзначное число");
            int.TryParse(Console.ReadLine(), out P);
            if (P < 100 || P > 999)
            {
                Console.WriteLine("Введённое число не соответствует требованиям");
            }
            else
            {
                Console.WriteLine(Number(P));
            }
            
        }
    }
}
