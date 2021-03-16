using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter fOut = new StreamWriter(new FileStream("../../../t.txt", FileMode.Create)))
            {
                Random rand = new Random();
                for (int i = 0; i < 100; i++)
                    fOut.WriteLine(rand.NextDouble() * 900 + 100);
            }
            using (StreamReader fIn = new StreamReader(new FileStream("../../../t.txt", FileMode.Open)))
            {
                Console.SetIn(fIn);
                double sum = 0;
                for (int i = 0; i < 100; i++)
                {
                    sum += double.Parse(Console.ReadLine());
                }
                Console.WriteLine(sum / 100);
                Console.SetIn(new StreamReader(Console.OpenStandardInput()));
            }
        }
    }
}
