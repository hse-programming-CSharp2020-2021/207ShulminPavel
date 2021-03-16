using System;

namespace Task_1
{
    interface IFigure
    {
        public double Square { get; }
    }

    class Sqad : IFigure
    {
        double side;
        public double Side
        {
            get
            {
                return side;
            }
        }

        public Sqad (double side)
        {
            this.side = side;
        }
        public double Square => side * side;

        public override string ToString()
        {
            return $"Квадрат\nСторона: {Side}\nПлощадь: {Square}";
        }
    }

    class Circle : IFigure
    {
        double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
        }

        public Circle (double radius)
        {
            this.radius = radius;
        }

        public double Square => Math.PI * radius * radius;

        public override string ToString()
        {
            return $"Круг\nРадиус: {Radius}\nПлощадь: {Square}";
        }
    }


    class Program
    {
        public static void PrintInfo<T>(T[] figures, double minSquare) where T : IFigure
        {
            foreach (T figure in figures)
            {
                if (figure.Square > minSquare)
                    Console.WriteLine(figure);
            }
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            IFigure[] figures = new IFigure[10];
            for(int i = 0; i < 10; i++)
            {
                switch (rand.Next(2))
                {
                    case 0:
                        figures[i] = new Sqad(rand.NextDouble() * 10);
                        break;
                    case 1:
                        figures[i] = new Circle(rand.NextDouble() * 10);
                        break;
                }
            }
            double limit = double.Parse(Console.ReadLine());
            PrintInfo(figures, limit);
        }
    }
}
