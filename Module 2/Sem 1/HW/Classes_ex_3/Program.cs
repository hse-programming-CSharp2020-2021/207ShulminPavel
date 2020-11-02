using System;
public class Polygon
{ // Класс многоугольников
    int numb;		// Число сторон
    double radius;	// Радиус вписанной окружности
    public Polygon(int n = 3, double r = 1)
    { // конструктор       
        numb = n;
        radius = r;
    }
    public double Perimeter
    { // Периметр многоугольника - свойство
        get
        {   // аксессор свойства
            double term = Math.Tan(Math.PI / numb);
            return 2 * numb * radius * term;
        }
    }

    public double Area
    { // Площадь многоугольника - свойство
        get
        {   // аксессор свойства
            return Perimeter * radius / 2;
        }
    }
    public string PolygonData()
    {
        string res =
        string.Format("N={0}; R={1}; P={2,2:F3}; S={3,4:F3}",
        numb, radius, Perimeter, Area);
        return res;
    }
}   // Polygon 
public class Program
{
    public static void Main()
    {
        Polygon polygon = new Polygon();
        Console.WriteLine("Введите количество многоугольников");
        double rad;
        int number;
        int n;
        while (!int.TryParse(Console.ReadLine(), out n)) ;
        Polygon[] array = new Polygon[n];

        do
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = new Polygon();
                do Console.Write($"Введите число сторон {i + 1} многоугольника: ");
                while (!int.TryParse(Console.ReadLine(), out number) | number < 3);
                do Console.Write($"Введите радиус вписанной окружности {i + 1} многоугольника: ");
                while (!double.TryParse(Console.ReadLine(), out rad) | rad < 0);
                array[i] = new Polygon(number, rad);
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Сведения о многоугольнике под номером {i + 1}:");
                Console.WriteLine(array[i].PolygonData());
            }
            Console.WriteLine("Для выхода нажмите клавишу ESC");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}