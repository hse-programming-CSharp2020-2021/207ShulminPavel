using System;

namespace Task_2
{
    class LatinChar
    {
        private char _char;
        public char Char
        {
            get
            {
                return _char;
            }
            set
            {
                if (value < 'a' || value > 'z')
                    throw new ArgumentException("Incorrect value");
                _char = value;
            }
        }
        public LatinChar()
        {
            Char = 'a';
        }
        public LatinChar(char symbol)
        {
            Char = symbol;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char minChar;
            char maxChar;
            while (!char.TryParse(Console.ReadLine(), out minChar) || !char.TryParse(Console.ReadLine(), out maxChar) || minChar < 'a' || 
                minChar > 'z' || maxChar < 'a' || maxChar > 'z') ;
            for (char i = minChar; i <= maxChar; i++)
            {
                LatinChar charClass = new LatinChar(i);
                Console.Write(charClass.Char + " ");
            }
        }
    }
}
