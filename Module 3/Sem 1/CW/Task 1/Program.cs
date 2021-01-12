using System;

namespace Task_1
{
    class Program
    {
        public static int[] FormMass(int number)
        {
            int k = 0;
            int numberCopy = number;
            while (number != 0)
            {
                k++;
                number /= 10;
            }
            int[] arr = new int[k];
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                arr[i] = numberCopy % 10;
                numberCopy /= 10;
            }
            return arr;
        }
        
        public static void PrintMass(int[] arr)
        {
            foreach(int a in arr)
            {
                Console.Write($"{a} ");
            }
        }

        public delegate int[] FirstDelegate(int a);

        public delegate void SecondDelegate(int[] arr);

        static void Main(string[] args)
        {
            int n = 77777;
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 77, 80, 90, };
            FirstDelegate firs = new FirstDelegate(FormMass);
            SecondDelegate second = new SecondDelegate(PrintMass);
            PrintMass(FormMass(n));
            Console.WriteLine();
            PrintMass(arr);
            Console.WriteLine();
            Console.WriteLine($"{firs.Method}\t{firs.Target}");
            Console.WriteLine($"{second.Method}\t{second.Target}");
        }
    }
}
