﻿using System;

namespace DoubleArr
{
    /*Определить класс Circle с полем радиус _r и свойством доступа к нему, 
     * значение радиуса положительное вещественное число. 
     * В классе Circle описать конструктор без параметров и конструктор с 
     * вещественным параметром. Определить свойство S – площадь круга 
     * заданного радиуса.
     * 
     * 
     * В основной программе получить от пользователя 
     * диапазон изменения значения радиуса: (Rmin, Rmax), Rmin, Rmax – 
     * произвольные вещественные числа и величину шага delta разбиения 
     * данного диапазона. Создать объект типа Circle, последовательно 
     * изменяя значение радиуса на delta вычислять и выводить на экран 
     * значение площади круга, ограниченного данной окружностью.
*/
    class Circle
    {
        private double _r;

        public double R
        {
            get
            {
                return _r;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Negative value");
                _r = value;
            }
        }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

        public double P
        {
            get
            {
                return Math.PI * 2 * _r;
            }
        }
        public Circle()
        {
            R = 1;
        }

        public Circle(double radius)
        {
            R = radius;
        }

        public override string ToString()
        {
            return $"Circle: radius = {_r}, square = {S}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double maxS = 0;
            int maxI = 0;
            double rmin = double.Parse(Console.ReadLine());
            double rmax = double.Parse(Console.ReadLine());
            uint n;
            while (!uint.TryParse(Console.ReadLine(), out n)) ;
            Circle[] circles = new Circle[n];

            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle(rnd.NextDouble() * (rmax - rmin) + rmin);
                Console.WriteLine($"{i + 1}. Площадь - {circles[i].S.ToString("F3")}; периметр - {circles[i].P.ToString("F3")}.");
                if (circles[i].S > maxS)
                {
                    maxS = circles[i].S;
                    maxI = i;
                }
            }
            Console.WriteLine($"Круг с наибольшей площадью под номером {maxI + 1}");
        }
    }
}