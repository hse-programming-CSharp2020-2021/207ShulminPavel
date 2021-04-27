using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Fibbonacci fi = new Fibbonacci();
            TriAngle tri = new TriAngle();
            foreach (int numb in fi.nextMemb(7))
                Console.Write(numb + "  ");
            Console.WriteLine();
            foreach (int numb in tri.nextMemb(7))
                Console.Write(numb + "  ");
            Console.WriteLine();
        }
    }

    class Fibbonacci
    {
        int last = 1;
        int previous = 0;

        public IEnumerable nextMemb(int count)
        {
            for (int i = 0; i < count; i++)
            {
                yield return last;
                int buff = last;
                last = last + previous;
                previous = buff;
            }
        }
    }

    class TriAngle
    {
        int n = 1;

        public IEnumerable nextMemb(int count)
        {
            for(int i = 0; i < count; i++)
            {
                yield return n * (n + 1) / 2;
                n++;
            }
        }
    }
}
