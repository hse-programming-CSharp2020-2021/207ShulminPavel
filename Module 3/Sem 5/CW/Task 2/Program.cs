using System;
using System.Collections.Generic;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    stack.Push(str[i]);
                }
                else
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch
                    {
                        Console.WriteLine("Последовательность неправильная.");
                    }
                }
            }
        }
    }
}
