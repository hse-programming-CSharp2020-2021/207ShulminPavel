using System;
using System.IO;
using MyLibrary;

namespace Task_2
{
    class Program
    {
        const string path = "../../../../out.txt";
        static void Main(string[] args)
        {
            string[] streets = File.ReadAllLines(path);
            int n = streets.Length;
            Street[] streetsArray = new Street[n];
            for (int i = 0; i < n; i++)
            {
                string[] street = streets[i].Split(' ');
                string name = street[0];
                int[] houses = new int[street.Length - 1];
                for (int j = 0; j < houses.Length; j++)
                {
                    houses[j] = int.Parse(street[j + 1]);
                }
                streetsArray[i] = new Street(name, houses);
            }
            for (int i = 0; i < streetsArray.Length; i++)
            {
                if (~streetsArray[i] % 2 == 1 && !streetsArray[i])
                    Console.WriteLine(streetsArray[i]);
            }
        }
    }
}
