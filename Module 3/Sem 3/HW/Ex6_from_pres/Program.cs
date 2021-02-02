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
                arr[i, j] = rnd.Next(100);
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
        Console.WriteLine($"Новая сумма:\t{sum}");
    }
}
class Program
{
    static void Main()
    {
        int[,] arr = new int[15, 15];
        Methods.NewItemFilled += Methods.ArraySumCount;
        Methods.ArrayFill(arr);

        // в качестве обработчика - лямбда-выражение
        Methods.LineComplete += () => { Console.WriteLine(); };
        Methods.ArrayPrint(arr);
    }
}

