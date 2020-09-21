using System;

namespace Task1//Слайд 13 задача 1
{
    class Program
    {
        public static void NumFinder()
        {
            int ans = 1, x = 0;
            for (int i = 2; (ans % 10) != (ans / 10 % 10) || (ans / 10 % 10) != (ans / 100); i++)
            {
                ans += i;
                x = i;
            }
            Console.WriteLine($"Число {ans}\nКоличество слагаемых {x}");
            Console.WriteLine($"1+2+3+...+{x - 2}+{x - 1}+{x}");
        }
        static void Main(string[] args)
        {
            NumFinder();
        }
    }
}
