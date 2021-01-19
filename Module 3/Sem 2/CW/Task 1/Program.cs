using System;

namespace Task_1
{
    delegate string ConvertRule(ref string str);

    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr.Invoke(ref str);
        }
    }
    class Program
    {
        public static string RemoveDigits(ref string str)
        {
            for (int i = 0; i < 10; i++)
            {
                str = str.Replace(i.ToString(), String.Empty);
            }
            return str;
        }

        public static string RemoveSpaces(ref string str)
        {
            return str.Replace(" ", "");
        }
        static void Main(string[] args)
        {
            string[] strArr = new string[]
            {
                "1asrg   66dfgh00 123abc45",
                "111111    Empty  222222  777",
                "123456789test string765433456"
            };
            ConvertRule cr1 = new ConvertRule(RemoveDigits);
            cr1 += RemoveSpaces;
            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(cr1.Invoke(ref strArr[i]));
            }
        }
    }
}
