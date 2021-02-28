using System;

namespace Task_1
{
    struct Coords
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

        public Coords (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Circle
    {
        double radius;
        Coords center;

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

        public Coords Center
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

        public Circle (double centerX, double centerY, double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным.");
            }
            else
            {
                center = new Coords(centerX, centerY);
                this.radius = radius;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5, 5, 10);
        }
    }
}
