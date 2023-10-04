// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

using System;
public class Exs2_36
{
    public static void Main(string[] args)
    {
        int[] myArray = new int[10];
        FillArray100to100(myArray);
        PrintArray(myArray);
        Console.WriteLine($" -> {SumElementsWithOddPosition(myArray)}");
    }
    public static void FillArray100to100(int[] array)
    {
        for(int i=0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-100, 100);
        }
    }
    public static void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]}, ");
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}]");
            }
            else
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
    public static int SumElementsWithOddPosition(int[] array)
    {
        int result = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i]%2 != 0)
            {
                result+=array[i];
            }
        }
        return result;
    }
}