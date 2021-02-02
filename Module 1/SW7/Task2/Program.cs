using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = File.ReadAllText("Untitled", System.Text.Encoding.Unicode);
            Console.WriteLine(str);
        }
    }
}
