using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x;
            int.TryParse(s, out x);
            char ans;
            ans = (char)x;
            Console.WriteLine(ans);
        }
    }
}
