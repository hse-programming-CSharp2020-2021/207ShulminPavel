using System;

namespace Task6//Слайд 14 задача 4
{
    class Program
    {
        public static int Method(uint a, uint b, uint c)
        {
            uint ans = 0;
            int min = 0, a1 = (int)a % 100, b1 = (int)b % 100, c1 = (int)c % 100;
            min = (a1 < b1) ? (a1 < c1) ? a1 : c1 : (b1 < c1) ? b1 : c1;
            if (min == a1)
            {
                ans = a;
            }
            if (min == b1)
            {
                ans = b;
            }
            if (min == c1)
            {
                ans = c;
            }
            return (int)ans;
        }
        static void Main(string[] args)
        {
            uint a,b,c;
            if (uint.TryParse(Console.ReadLine(), out a) && uint.TryParse(Console.ReadLine(), out b) && uint.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine(Method(a, b, c));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
