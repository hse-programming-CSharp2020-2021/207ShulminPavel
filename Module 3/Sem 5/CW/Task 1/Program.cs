using System;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            LinkedList<int> list = new LinkedList<int>();
            Stack<int> stack = new Stack<int>();
            while (n > 0)
            {
                int k = n % 10;
                n /= 10;
                list.AddFirst(k);
                stack.Push(k);
            }
            Console.WriteLine("from linkedList");
            foreach (int a in list)
                Console.Write($"{a} ");
            Console.WriteLine("\nfrom stack");
            foreach (int a in stack)
                Console.Write($"{a} ");
        }
    }
}
