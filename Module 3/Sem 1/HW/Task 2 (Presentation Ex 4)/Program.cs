using System;

namespace Task_2__Presentation_Ex_4_
{
    class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости 

        public void Right() { x++; }      // направо
        public void Left() { x--; }      // налево
        public void Forward() { y++; }  // вперед
        public void Backward() { y--; }  // назад

        public string Position()
        {  // сообщить координаты
            return String.Format("The Robot position: x={0}, y={1}", x, y);
        }
    }
    delegate void Steps(); // делегат-тип
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot();    // конкретный робот 
            Console.WriteLine($"Start: {rob.Position()}");
            string s = Console.ReadLine();
            char[] commands = s.ToCharArray();
            Steps robTrip = null;
            foreach (char a in commands)
            {
                switch (a)
                {
                    case 'R':
                        robTrip += rob.Right;
                        break;
                    case 'L':
                        robTrip += rob.Left;
                        break;
                    case 'F':
                        robTrip += rob.Forward;
                        break;
                    case 'B':
                        robTrip += rob.Backward;
                        break;
                    default:
                        Console.WriteLine("Несуществующая команда.");
                        break;
                }
            }
            robTrip?.Invoke();

            Console.WriteLine(rob.Position());     // сообщить координаты
        }
    }
}
