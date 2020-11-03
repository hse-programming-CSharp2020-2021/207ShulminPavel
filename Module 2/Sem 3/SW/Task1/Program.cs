using System;

namespace Task1
{
    class SinFunction
    {
        public double xMin
        {
            get;set;
        }
        public double xMax
        {
            get;set;
        }
        public SinFunction(double Min, double Max)
        {
            xMin = Min;
            xMax = Max;
        }
        public double this[double index]
        {
            get
            {
                if (index < xMin || index > xMax)
                {
                    return 0;
                }
                return Math.Sin(index);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            SinFunction s = new SinFunction(0, Math.PI);
            for (double i = 0; i <= Math.PI; i += Math.PI/6)
            {
                Console.WriteLine($"синус {k}*PI/6 = {s[i]:F3}");
                k++;
            }
        }
    }
}
