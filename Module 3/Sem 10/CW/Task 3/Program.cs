using System;

namespace Task_3
{
    class Program
    {
        struct Rectangle : IComparable
        {
            public double Length { get; private set; }
            public double Width { get; private set; }
            public double Sqare
            {
                get
                {
                    return Length * Width;
                }
            }

            public Rectangle (double length, double width)
            {
                Length = length;
                Width = width;
            }

            public int CompareTo(object obj)
            {
                return Sqare.CompareTo(((Rectangle)obj).Sqare);
            }
        }

        class Block3D : IComparable
        {
            public double Height { get; private set; }
            public Rectangle Base { get; private set; }

            public Block3D(double height, Rectangle rectangle)
            {
                Height = height;
                Base = rectangle;
            }

            public int CompareTo(object obj)
            {
                return Base.Sqare.CompareTo(((Block3D)obj).Base.Sqare);
            }

            public override string ToString()
            {
                return $"Площадь основания: {Base.Sqare}\nВысота: {Height}";
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            Block3D[] bricks = new Block3D[10];
            for (int i = 0; i < 10; i++)
            {
                bricks[i] = new Block3D(rand.NextDouble() * 10, new Rectangle(rand.NextDouble() * 50 + 10, rand.NextDouble() * 10));
                Console.WriteLine(bricks[i]);
            }
            Console.WriteLine("Сортировка");
            Array.Sort(bricks);
            foreach (Block3D brick in bricks)
                Console.WriteLine(brick);
        }
    }
}
