using System;

namespace Task4//Слайд 14 задача 2
{
    class Program
    {
        public static double G(double x, double y)
        {
            double ans;
            if (x < y && x > 0)
            {
                ans = x + Math.Sin(y);
            }
            else
            {
                if (x > y && x < 0)
                {
                   ans = y - Math.Cos(x);
                }
                else
                {
                    ans = 0.5 * x * y;
                }
            }
            return (ans);
        }
        static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine(G(x, y).ToString("F3"));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
