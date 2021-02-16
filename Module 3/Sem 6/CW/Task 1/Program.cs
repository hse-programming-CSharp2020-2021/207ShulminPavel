using System;

namespace Task_1
{

    interface ICalculation
    {
        double Perform(double a);
    }

    class Add : ICalculation
    {
        double value;

        public Add (double value)
        {
            this.value = value;
        }

        public double Perform(double x)
        {
            return value + x;
        }
    }

    class Multiply : ICalculation
    {
        double value;

        public Multiply(double value)
        {
            this.value = value;
        }

        public double Perform(double x)
        {
            return value * x;
        }
    }

    class Program
    {
        public static double Calculate(double a, Add add, Multiply multiply)
        {
            return multiply.Perform(add.Perform(a));
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(a, new Add(2), new Multiply(3)));
        }
    }
}
