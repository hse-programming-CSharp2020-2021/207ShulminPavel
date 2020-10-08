using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0) ;
            string path = "IntNumber.txt";
            string ans = "";
            for (int i = 0;  n > 0; i++)
            {
                ans += n % 2 * Math.Pow(10.0, i);
                n /= 2;
            }
            File.WriteAllText(path, (string)ans);
        }
    }
}
