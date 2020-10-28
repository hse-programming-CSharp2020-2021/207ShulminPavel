using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][][] a = new char[3][][];
            a[0] = new char[3][];

            a[0][0] = new char[] { 'a', 'b' };
            a[0][1] = new char[] { 'c', 'd', 'e' };
            a[0][2] = new char[] { 'f', 'g', 'h', 'i' };

            a[1] = new char[2][];

            a[1][0] = new char[] { 'j', 'k' };
            a[1][1] = new char[] { 'l', 'm', 'n' };

            a[2] = new char[1][];

            a[2][0] = new char[] { 'o', 'p', 'q', 'r' };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    for (int k = 0; k < a[i][j].Length; k++)
                    {
                        Console.Write($"{a[i][j][k]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine('\n');
            }
        }
    }
}
