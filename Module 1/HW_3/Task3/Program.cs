using System;

namespace Task3//Слайд 14 задача 1
{
    class Program
    {
        public static bool G(double x, double y)
        {
            if (x*x + y*y <= 4 && y <= x && x >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out double x) && double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine(G(x, y));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
