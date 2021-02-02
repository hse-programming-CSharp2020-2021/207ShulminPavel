using System;
public delegate void MethodsEvents();
public delegate void ItemEvents(int[,] ar);
public class Methods
{
    public static event MethodsEvents LineComplete; //  строка заполнена
    // новый элемент проинициализирован 
    public static event ItemEvents NewItemFilled;
    // метод заполнения массива
    public static void ArrayFill(int[,] arr)
    {
        Random rnd = new Random();
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                arr[i, j] = rnd.Next(1, 100);
                NewItemFilled?.Invoke(arr);
            }
    }
    public static void ArrayPrint(int[,] arr)
    {
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                Console.Write(arr[i, j] + " ");
            LineComplete(); // событие!!
        }
    }

    // обработчик события добавления элемента вычисляет сумму элементов
    public static void ArraySumCount(int[,] arr)
    {
        int sum = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
                sum += arr[i, j];
        }
        Console.Write($"Новая сумма: {sum}".PadRight(30));
    }

    public static void ArrayAverageCount(int[,] arr)
    {
        double av = 0;
        int sum = 0;
        int k = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] != 0)
                {
                    k++;
                    sum += arr[i, j];
                }
                else
                {
                    break;
                }
            }
        }
        av = sum / k;
        Console.Write($"Новое среднее арифметическое: {av}".PadRight(45));
    }

    public static void MaxFromArr(int[,] arr)
    {
        int max = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] > max)
                    max = arr[i, j];
            }
        }
        Console.WriteLine($"Максимальный элемент: {max}".PadRight(35));
    }
}
class Program
{
    static void Main()
    {
        int[,] arr = new int[15, 15];
        Methods.NewItemFilled += Methods.ArraySumCount;
        Methods.NewItemFilled += Methods.ArrayAverageCount;
        Methods.NewItemFilled += Methods.MaxFromArr;
        Methods.ArrayFill(arr);

        for (int i = 0; i < 120; i++)
            Console.Write("*");
        Console.WriteLine("\n");
        // в качестве обработчика - лямбда-выражение
        Methods.LineComplete += () => { Console.WriteLine(); };
        Methods.ArrayPrint(arr);
    }
}

