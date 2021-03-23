using System;
using MyLibrary;
using System.IO;

namespace Task_1
{
    class Program
    {
        const string input = "data.txt";

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] streets = File.ReadAllLines(input);
            Street[] streetsArray = new Street[n];
            if (!IsCorrect(streets))
            {
                Console.WriteLine("Улицы в файле заданы не корректно");
                Random rnd = new Random();
                streetsArray = new Street[n];
                for (int i = 0; i < n; i++)
                {
                    string name = ((char)rnd.Next(97, 123)).ToString() + 
                        ((char)rnd.Next(97, 123)).ToString() + ((char)rnd.Next(97, 123)).ToString();
                    int[] houses = new int[rnd.Next(11)];
                    for (int j = 0; j < houses.Length; j++)
                    {
                        houses[j] = rnd.Next(101);
                    }
                    streetsArray[i] = new Street(name, houses);
                }
            }
            else
            {
                n = n > streets.Length ? streets.Length : n;
                streetsArray = new Street[n];
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
            }
            string forSave = "";
            foreach (Street street in streetsArray)
            {
                Console.WriteLine(street);
                forSave += $"{street.ToString()}\n";
            }
            File.WriteAllText("../../../../out.txt", forSave);
        }

        public static bool IsCorrect(string[] streets)
        {
            for (int i = 0; i < streets.Length; i++)
            {
                string[] street = streets[i].Split(' ');
                if (street.Length < 2)
                    return false;
                for (int j = 1; j < street.Length; j++)
                {
                    if (!int.TryParse(street[j], out int n))
                        return false;
                }
            }
            return true;
        }
    }
}
