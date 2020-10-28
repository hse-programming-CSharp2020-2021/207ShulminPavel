using System;

namespace Task_2
{
    class Program
    {
        public static void Generate(int n, out double[]x, out double[] y)
        {
            Random rnd = new Random();
            x = new double[n];
            y = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = rnd.Next(-4, 4) + rnd.NextDouble();
                y[i] = rnd.Next(-4, 4) + rnd.NextDouble();
            }
        }
        public static bool Chek(double x, double y)
        {
            if (x * x + y * y >= 4 && x * x + y * y <= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Method(double[] x, double[] y)
        {
            double[] Xin = new double[0];
            double[] Yin = new double[0];
            double[] Xout = new double[0];
            double[] Yout = new double[0];
            for (int i = 0; i < x.Length; i++)
            {
                if (Chek(x[i], y[i]))
                {
                    Array.Resize(ref Xin, Xin.Length + 1);
                    Xin[Xin.Length - 1] = x[i];
                    Array.Resize(ref Yin, Yin.Length + 1);
                    Yin[Yin.Length - 1] = y[i];
                }
                else
                {
                    Array.Resize(ref Xout, Xout.Length + 1);
                    Xout[Xout.Length - 1] = x[i];
                    Array.Resize(ref Yout, Yout.Length + 1);
                    Yout[Yout.Length - 1] = y[i];
                }
            }
            Array.ForEach(Xin, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine();
            Array.ForEach(Yin, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine('\n');
            Array.ForEach(Xout, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine();
            Array.ForEach(Yout, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine('\n');
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10000) ;
            double[] x = new double[n];
            double[] y = new double[n];
            Generate(n, out x, out y);
            Array.ForEach(x, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine();
            Array.ForEach(y, x => Console.Write($"{x.ToString("F3")}\t"));
            Console.WriteLine('\n');
            Method(x, y);
        }
    }
}
