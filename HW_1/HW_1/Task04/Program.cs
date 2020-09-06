using System;
using System.Security.Cryptography;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            double.TryParse(s1, out U);
            double.TryParse(s2, out R);
            double I = U / R, P = U * U / R;
            Console.WriteLine(I.ToString("F6"));
            Console.WriteLine(P.ToString("F6"));

        }
    }
}
