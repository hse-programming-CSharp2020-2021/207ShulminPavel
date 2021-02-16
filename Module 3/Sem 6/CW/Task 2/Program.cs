using System;

namespace Task_2
{
    interface ISequence
    {
        double GetElement(int index);
    }

    class ArithmeticProgression : ISequence
    {
        double n1;
        double d;
        public ArithmeticProgression(double n1, double d)
        {
            this.n1 = n1;
            this.d = d;
        }

        public double GetElement(int index)
        {
            return n1 + d * (index - 1);
        }
    }

    class GeomrtricProgression : ISequence
    {
        double n1;
        double d;
        public GeomrtricProgression(double n1, double d)
        {
            this.n1 = n1;
            this.d = d;
        }

        public double GetElement(int index)
        {
            return n1 * Math.Pow(d, index - 1);
        }
    }

    class Program
    {
        public static double Sum (ArithmeticProgression ap, int index)
        {
            double sum = 0;
            for (int i = 1; i <= index; i++)
            {
                sum += ap.GetElement(i);
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(new ArithmeticProgression(1, 1), 5));
        }
    }
}
