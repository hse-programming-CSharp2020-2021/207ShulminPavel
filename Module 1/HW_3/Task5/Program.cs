using System;

namespace Task5//Слайд 14 задача 3
{
    class Program
    {
        public static double G(double x)
        {
            if (x <= 0.5)
            {
                return Math.Sin(Math.PI / 2);
            }
            else
            {
                return Math.Sin(Math.PI * (x - 1) / 2);
            }
        }
        static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine(G(x));
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
