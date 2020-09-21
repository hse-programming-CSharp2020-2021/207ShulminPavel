using System;

namespace Task2//Слайд 13 задача 2
{
    class Program
    {
        public static uint Revers(uint a)
        {
            uint ans = 0;
            while (a > 0)
            { 
                ans = ans * 10 + a % 10;
                a /= 10;
            }
            return ans;
        }
        static void Main(string[] args)
        {
            if (uint.TryParse(Console.ReadLine(), out uint x))
            {
                Console.WriteLine(Revers(x));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
