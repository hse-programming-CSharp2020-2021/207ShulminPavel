using System;
using System.IO;
class Program
{
    static void Main()
    {
        using (BinaryWriter fOut = new BinaryWriter(new FileStream("../../../t.dat", FileMode.Create)))
        {
            for (int i = 0; i <= 10; i += 2)
                fOut.Write(i);
        }
        using (FileStream f = new FileStream("../../../t.dat", FileMode.Open))
        using (BinaryReader fIn = new BinaryReader(f))
        {
            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }

            Console.WriteLine("\nЧисла в обратном порядке:");
        // 1) TODO: Прочитать и напечатать все числа из файла в обратном порядке
            for (int i = 1; i <= n; i++)
            {
                f.Seek(-4 * i, SeekOrigin.End);
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }
        }
        // 2) TODO: увеличить  все числа в файле в 5 раз
        using (FileStream f = new FileStream("../../../t.dat", FileMode.Open))
        using (BinaryReader fIn = new BinaryReader(f))
        using (BinaryWriter fOut = new BinaryWriter(f))
        {
            while (fOut.BaseStream.Position < fOut.BaseStream.Length)
            {
                int a;
                a = fIn.ReadInt32();
                f.Position -= 4;
                fOut.Write(a * 5);
            }
        }
        Console.WriteLine();
        // 3) TODO: Прочитать и напечатать все числа из файла в прямом порядке
        using (FileStream f = new FileStream("../../../t.dat", FileMode.Open))
        using (BinaryReader fIn = new BinaryReader(f))
        {
            long n = f.Length / 4; int a;
            for (int i = 0; i < n; i++)
            {
                a = fIn.ReadInt32();
                Console.Write(a + " ");
            }
        }
        }
}