using System;

namespace Task_3
{
    class State
    {
        public decimal Population
        {
            get;
            set;
        }

        decimal Area
        {
            get;
            set;
        }

        public static State operator +(State a, State b)
        {
            return new State() { Area = a.Area + b.Area, Population = a.Population + b.Population };
        }

        public static bool operator >(State a, State b)
        {
            return a.Area > b.Area;
        }

        public static bool operator <(State a, State b)
        {
            return a.Area < b.Area;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
