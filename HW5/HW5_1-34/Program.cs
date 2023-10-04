// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

using System;
public class Exs1_34
{
    public static void Main(string[] args)
    {
        int[] myArray = new int[10];
        FillArray3Digit(myArray);
        PrintArray(myArray);
        Console.WriteLine($" -> {CountEvenNumInTheArray(myArray)}");
    }
    public static void FillArray3Digit(int[] array)
    {
        for(int i=0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
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
    public static int CountEvenNumInTheArray(int[] array)
    {
        int result = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i]%2 == 0)
            {
                result++;
            }
        }
        return result;
    }
}