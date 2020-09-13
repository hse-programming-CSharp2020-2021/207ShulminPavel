using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine(), s2 = Console.ReadLine();
            double a, b;
            double.TryParse(s1, out a);
            double.TryParse(s2, out b);
            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine(c);
        }
    }
}
