using System;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Task_3
{
    [DataContract]
    [Serializable]
    public struct ConsoleSymbolStruct
    {
        [DataMember]
        public char symb;
        [DataMember]
        public int x;
        [DataMember]
        public int y;

        [DataMember]
        public char Symb { get => symb; set { symb = value; } }
        [DataMember]
        public int X { get => x; set { x = value; } }
        [DataMember]
        public int Y { get => y; set { y = value; } }

        public ConsoleSymbolStruct(char symb, int x, int y)
        {
            this.symb = symb;
            this.x = x;
            this.y = y;
        }
    }
    class Program
    {
        public static void BinarySerialization(ConsoleSymbolStruct[] symbols)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("binSer.dat", FileMode.Create))
            {
                formatter.Serialize(fs, symbols);
            }
        }

        public static ConsoleSymbolStruct[] BinaryDeserialization()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("binSer.dat", FileMode.Open))
            {
                return (ConsoleSymbolStruct[])formatter.Deserialize(fs);
            }
        }

        public static void XmlSerialization(ConsoleSymbolStruct[] symbols)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("xmlSer.xml", FileMode.Create))
            {
                serializer.Serialize(fs, symbols);
            }
        }

        public static ConsoleSymbolStruct[] XmlDeserialization()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConsoleSymbolStruct[]));
            using (FileStream fs = new FileStream("xmlSer.xml", FileMode.Open))
            {
                return (ConsoleSymbolStruct[])serializer.Deserialize(fs);
            }
        }

        public static string JsonSerialization(ConsoleSymbolStruct[] symbols)
        {
            return JsonSerializer.Serialize(symbols);
        }

        public static ConsoleSymbolStruct[] JsonDeserialization(string str)
        {
            return JsonSerializer.Deserialize<ConsoleSymbolStruct[]>(str);
        }

        public static void DataContractSerialization(ConsoleSymbolStruct[] symbols)
        {
            using (FileStream fs = new FileStream("dataSer.txt", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(ConsoleSymbolStruct[]));
                serializer.WriteObject(fs, symbols);
            }
        }

        public static ConsoleSymbolStruct[] DataContractDeserialization()
        {
            using (FileStream fs = new FileStream("dataSer.txt", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(ConsoleSymbolStruct[]));
                return (ConsoleSymbolStruct[])serializer.ReadObject(fs);
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = int.Parse(Console.ReadLine());
            ConsoleSymbolStruct[] symbols = new ConsoleSymbolStruct[n];
            for (int i = 0; i < n; i++)
            {
                char symb = (char)rand.Next(33, 127);
                int x = rand.Next(Console.WindowWidth);
                int y = rand.Next(1000);
                symbols[i] = new ConsoleSymbolStruct(symb, x, y);
            }
            BinarySerialization(symbols);
            BinaryDeserialization();
            XmlSerialization(symbols);
            XmlDeserialization();
            JsonDeserialization(JsonSerialization(symbols));
            DataContractSerialization(symbols);
            DataContractDeserialization();
        }
    }
}
