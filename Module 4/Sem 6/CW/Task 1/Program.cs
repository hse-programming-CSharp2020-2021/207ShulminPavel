using System;
using System.Linq;

namespace Task_1
{
    class Program
    {
        public static int[] GenerateArray()
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-10000, 10001);
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] arr = GenerateArray();

            var lastNum1 = arr.Select(x => x % 10).ToArray();
            var lastNum2 = from num in arr
                           select num % 10;

            var grouping1 = arr.GroupBy(x => x % 10).ToArray();
            var grouping2 = from num in arr
                            group num by num % 10;

            var chetAndPolozh1 = arr.Where(x => x > 0 && x % 2 == 0).ToArray();
            Console.WriteLine(chetAndPolozh1.Length);
            var chetAndPolozh2 = from num in arr
                                 where num > 0 && num % 2 == 0
                                 select num;
            Console.WriteLine(chetAndPolozh2.ToArray().Length);

            var sum1 = arr.Where(x => x % 2 == 0).Sum();
            var buffArr = from num in arr
                       where num % 2 == 0
                       select num;
            var sum2 = buffArr.Sum();

            var sort1 = arr.OrderBy(x => int.Parse(x.ToString()[0].ToString())).ThenBy(x => x % 10);
            var sort2 = from num in arr
                        orderby int.Parse(num.ToString()[0].ToString()), num % 10
                        select num;
        }
    }
}
