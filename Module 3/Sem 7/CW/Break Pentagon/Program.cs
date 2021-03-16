using System;

namespace Break_Pentagon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.Green;
            while(true)
            {
                Console.Write(rand.Next(2));
            }
        }
    }
}
