using System;

namespace Task_2
{
    class Program
    {
        public delegate int Cast(double d);
        static void Main(string[] args)
        {
            Cast first = delegate (double d)
            {
                if ((int)d % 2 == 0)
                {
                    return (int)d;
                }
                else
                    return (int)d + 1;
            };
            Cast second = delegate (double d)
            {
                if (d > 0)
                {
                    return (int)Math.Log10(d) + 1;
                }
                else
                    throw new ArgumentException();
            };
            Cast third = d =>
            {
                if ((int)d % 2 == 0)
                {
                    return (int)d;
                }
                else
                    return (int)d + 1;
            };
            Cast fouth = d =>
            {
                if (d > 0)
                {
                    return (int)Math.Log10(d) + 10;
                }
                else
                    throw new ArgumentException();
            };
            Cast sum = first;
            sum += second;
            Console.WriteLine(sum?.Invoke(10.333));
        }
    }
}
