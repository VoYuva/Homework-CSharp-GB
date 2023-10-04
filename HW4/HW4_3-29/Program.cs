// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using System;
public class Exs3_29
{
    public static void Main (string[] args)
    {
        int[] array = new int[8];
        RandomFillArray(array);
        PrintArray(array);

    }

    public static void RandomFillArray(int[] myArray)
    {
        for(int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = new Random().Next(1, 100);
        }
    }

    public static void PrintArray(int[] myArray)
    {
        for(int i = 0; i < myArray.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{myArray[i]}, ");
            }
            else if (i == myArray.Length - 1)
            {
                Console.WriteLine($"{myArray[i]}]");
            }
            else
            {
                Console.Write($"{myArray[i]}, ");
            }
        }
    }
}
