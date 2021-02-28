using System;

namespace Task_1
{
    struct Points
    {
        double x;
        double y;

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public Points(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Distance(Points otherPoints)
        {
            return Math.Sqrt(Math.Pow(X - otherPoints.X, 2) + Math.Pow(Y - otherPoints.Y, 2));
        }
    }

    struct Circles : IComparable
    {
        double radius;
        Points center;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Радиус не может быть отрицательным.");
                }
                else
                {
                    radius = value;
                }
            }
        }

        public Points Center
        {
            get
            {
                return center;
            }
            set
            {
                center = value;
            }
        }

        public Circles(double centerX, double centerY, double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            else
            {
                center = new Points(centerX, centerY);
                this.radius = radius;
            }
        }

        public double Legth
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override string ToString()
        {
            return $"Центр: ({center.X},{center.Y})\nРадиус: {Radius}\nПериметр: {Legth}";
        }

        public int CompareTo(object obj)
        {
            return Radius.CompareTo(((Circles)obj).Radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Circles[] arr = new Circles[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Circles(rand.NextDouble() * 10, rand.NextDouble() * 10, rand.NextDouble() * 10);
            }
            foreach (Circles c in arr)
            {
                Console.WriteLine(c);
            }
            Array.Sort(arr);
            Console.WriteLine("Сортировка");
            foreach (Circles c in arr)
            {
                Console.WriteLine(c);
            }
        }
    }
}
