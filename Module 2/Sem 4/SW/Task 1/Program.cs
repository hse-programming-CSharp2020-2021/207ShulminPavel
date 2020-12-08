using System;

namespace Task_1
{
    class Point
    {
        double x;
        double y;
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
    }
    class Triangle
    {
        Point a;
        Point b;
        Point c;
        private double AB => GetLengthOfSide(a, b);
        private double AC => GetLengthOfSide(a, c);
        private double BC => GetLengthOfSide(b, c);
        public Triangle()
        {
            a = new Point();
            b = new Point();
            c = new Point();

        }
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            a = new Point(x1, y1);
            b = new Point(x2, y2);
            c = new Point(x3, y3);
        }
        public Triangle(Point a, Point b, Point c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public double GetAB
        {
            get
            {
                return AB;
            }
        }
        public double GetBC
        {
            get
            {
                return BC;
            }
        }
        public double GetAC
        {
            get
            {
                return AC;
            }
        }
        public bool ExistenceOfATriangle()
        {
            if (AB + BC <= AC || AB + AC <= BC || BC + AC <= AB)
            {
                return false;
            }
            return true;
        }
        public double P
        {
            get
            {
                return AB + AC + BC;
            }
        }
        public double S
        {
            get
            {
                double p = (AB + AC + BC) / 2;
                return Math.Sqrt(p * (p - AB) * (p - AC) * (p - BC));
            }
        }
        private static double GetLengthOfSide(Point first, Point second)
        {
            return Math.Sqrt(Math.Pow(first.X - second.X, 2) + Math.Pow(first.Y - second.Y, 2));
        }
        public override string ToString()
        {
            string newToString = "";
            newToString += $"Сторона AB = {AB:F3}\n";
            newToString += $"Сторона BC = {BC:F3}\n";
            newToString += $"Сторона AC = {AC:F3}\n";
            newToString += $"Периметр = {P:F3}\n";
            newToString += $"Площадь = {S:F3}\n";
            return newToString;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Random rnd = new Random();
            do
            {
                Console.Clear();
                int n = rnd.Next(5, 16);
                Triangle[] arrayOfTriangles = new Triangle[n];
                for (int i = 0; i < arrayOfTriangles.Length; i++)
                {
                    Point a = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
                    Point b = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
                    Point c = new Point(rnd.Next(-10, 11), rnd.Next(-10, 11));
                    arrayOfTriangles[i] = new Triangle(a, b, c);
                    while (!arrayOfTriangles[i].ExistenceOfATriangle())
                    {
                        arrayOfTriangles[i] = new Triangle(a, b, c);
                    }
                    Console.WriteLine($"{i + 1} Треугольник:\n");
                    Console.WriteLine(arrayOfTriangles[i]);
                }
                Console.WriteLine("Нажмите Escape чтобы завершить работу программы.");
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
