using System;

namespace Task1
{
    class Program
    {
        public static long Two(int a)
        {
            long ans1 = 10, ans = 0;
            while (a != 0)
            {
                ans1 = ans1 * 10 + a % 2;
                a /= 2;
            }
            while (ans1 !=0)
            {
                ans = ans * 10 + ans1 % 10;
                ans1 /= 10;
            }
            return ans % 10;
        }

        static void Main(string[] args)
        {
            int a;
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine(Two(a));
        }
    }
}
