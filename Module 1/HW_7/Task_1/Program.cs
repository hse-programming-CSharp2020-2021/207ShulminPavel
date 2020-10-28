using System;
using System.IO; // Пространство имён System.IO -> File.
using System.Text; // Кодировка.

class Program
{
    static Random rand = new Random();
    static void Main()
    {
        // основные настрйки
        const string fileName = "dialog.txt";
        Encoding enc = Encoding.Unicode;
        const int linesCount = 6;   // кол-во предложений

        // Создаем файл на диске 
        File.WriteAllText(fileName, string.Empty, enc); // Создаём пустой файл.
        Console.WriteLine("Переписка до форматирования:");
        for (int i = 0; i < linesCount; i++)
        {
            string message = string.Empty; // предложение
            int length = rand.Next(20, 51); // Длина сообщения от 20 до 50 символов (51 - 50 включён в диапазон)
            for (int j = 0; j < length; j++)
            {
                message += (char)rand.Next('А', 'Я'); // Посимвольное добавление букв в сообщение. "Ё" нет в диапазоне от А до Я!
            }
            message += "." + Environment.NewLine; // Добавляем в сообщение точку и перенос на следующую строку.
            File.AppendAllText(fileName, message, enc); // Добавляем строку в файл.
            Console.Write(message);
        }

        // читаем сформированный файл и обрабатываем предложения
        string[] messages = File.ReadAllLines(fileName, enc); // Массив сообщений из переписки.
        Console.WriteLine(Environment.NewLine + "Переписка после форматирования:");
        foreach (string item in messages)
            Console.WriteLine(item.Substring(0, item.Length - 1)); // Выводим сообщения из переписки без точек на экран.
    }
}