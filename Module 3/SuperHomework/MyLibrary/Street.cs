using System;

namespace MyLibrary
{
    public class Street
    {
        int[] houses = new int[0];

        public string Name { get; set; }

        public int[] Houses { get => houses; }

        public Street(string name, int[] houses)
        {
            Name = name;
            this.houses = houses;
        }

        public static int operator ~(Street street)
        {
            return street.Houses.Length;
        }

        public static bool operator !(Street street)
        {
            for (int i = 0; i < street.Houses.Length; i++)
            {
                if (street.Houses[i].ToString().Contains('7'))
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            string str = Name;
            foreach (int house in Houses)
                str += $" {house}";
            return str;
        }
    }
}
