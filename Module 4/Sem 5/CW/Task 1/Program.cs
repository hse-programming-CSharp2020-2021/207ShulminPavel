using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(-999, 1000);
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine('\n');
            var kvadrati = from num in numbers
                           select num * num;
            foreach (int a in kvadrati)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine('\n');
            var positiveTwo = from num in numbers
                              where num > 0 && Math.Log10(num) >= 1 && Math.Log10(num) < 2
                              select num;
            foreach (int a in positiveTwo)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine('\n');
            var sorting = from num in numbers
                          where num % 2 == 0
                          orderby num descending
                          select num;
            foreach (int a in sorting)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine('\n');
            var group = from num in numbers
                        group num by Math.Floor(Math.Log10(Math.Abs(num) + 1)); 
        }
    }
}
