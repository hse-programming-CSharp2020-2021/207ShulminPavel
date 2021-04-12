using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Task1
{
    delegate void Qdelegate(Quadratic eq);

    [Serializable]
    public class Quadratic
    {
        public int a;
        public int b;
        public int c;

        public int A { get => a; }
        public int B { get => b; }
        public int C { get => c; }
        public double Discriminant { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public Quadratic()
        {

        }

        public Quadratic(int a, int b, int c)
        {
            if (a == 0)
            {
                throw new ArgumentException("Coefficent \"a\" is zero.");
            }
            this.a = a;
            this.b = b;
            this.c = c;
            Discriminant = b * b - 4 * a * c;
            if (Discriminant >= 0)
            {
                X1 = (-b + Math.Sqrt(Discriminant)) / 2;
                X2 = (-b - Math.Sqrt(Discriminant)) / 2;
            }
        }

        public override string ToString()
        {
            if (b != 0 && c != 0)
            {
                return $"{a}x^2 + {b}x + {c} = 0";
            }
            else if (b == 0 && c != 0)
            {
                return $"{a}x^2 + {c} = 0";
            }
            else if (b != 0 && c == 0)
            {
                return $"{a}x^2 + {b}x = 0";
            }
            else if (b == 0 && c == 0)
            {
                return $"{a}x^2 = 0";
            }
            else
            {
                return "Уравнение не квадратное.";
            }
        }
    }

    class Processing
    {
        static Random gen = new Random();
        public static void SolutionReal(Quadratic eq)
        {
            if (eq.Discriminant >= 0)
            {
                Console.WriteLine($"{eq}\nD = {eq.Discriminant}\nx1 = {eq.X1.ToString("f3")}\nx2 = {eq.X2.ToString("f3")}");
                Console.WriteLine();
            }
        }
        public static void PrintEq(Quadratic eq)
        {
            Console.WriteLine(eq + $"\nD = {eq.Discriminant.ToString("g3")}");
            Console.WriteLine();
        }
        static public void WriteFile(string nameFile, int numb)
        {
            using (FileStream streamOut = new FileStream(nameFile, FileMode.Create))
            {
                XmlSerializer formatOut = new XmlSerializer(typeof(Quadratic));
                for (int j = 0; j < numb; j++)
                {
                    try
                    {
                        Quadratic q = new Quadratic(gen.Next(-10, 11),
                            gen.Next(-10, 11), gen.Next(-10, 11));
                        formatOut.Serialize(streamOut, q);
                    }
                    catch
                    {
                        j--;
                        continue;
                    }
                }
            }
        }
        public static void Process(string fileName, Qdelegate qDel)
        {
            using (FileStream streamIn = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer formatIn = new XmlSerializer(typeof(Quadratic));
                Quadratic eq;
                while (true)
                    try
                    {
                        eq = (Quadratic)formatIn.Deserialize(streamIn);
                        qDel(eq);
                    }
                    catch (SerializationException) { streamIn.Close(); break; }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Processing.WriteFile("equation.XML", 8);
            Console.WriteLine("Выполнена запись в режиме сериализации.");
            Console.WriteLine("Для вывода на экран нажмите любую клавишу.");
            Console.ReadKey(true);
            Console.WriteLine("В файле сведения о следующих уравнениях: ");
            Processing.Process("equation.XML", new Qdelegate(Processing.PrintEq));
            Console.WriteLine("Для решения уравнений нажмите любую клавишу.");
            Console.ReadKey(true);
            Console.WriteLine("\r\nРешения уравнений с вещественными корнями: ");
            Processing.Process("equation.ser", new Qdelegate(Processing.SolutionReal));
            Console.WriteLine("Для завершения работы нажмите ENTER.");
            Console.ReadLine();

        }
    }
}
