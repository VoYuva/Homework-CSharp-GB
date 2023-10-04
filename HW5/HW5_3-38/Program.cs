// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System;
public class Exs3_38
{
    public static void Main(string[] args)
    {
        double[] myArray = new double[10];
        FillArray(myArray);
        PrintArray(myArray);
        Console.Write(" -> ");
        DifferentOfMaxAndMinElementsInMassive(myArray);
    }
    public static void FillArray(double[] array)
    {
        for(int i=0; i < array.Length; i++)
        {
            //double rand = new Random;
            array[i] = new Random().Next(100, 10000);
            array[i]/=100;
        }
    }
    public static void PrintArray(double[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"[{array[i]:F2}, ");
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]:F2}]");
            }
            else
            {
                Console.Write($"{array[i]:F2}, ");
            }
        }
    }
    public static void DifferentOfMaxAndMinElementsInMassive(double[] array)
    {
        double min = 100;
        double max = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i]<min)
            {
                min = array[i];
            }
            else if(array[i]>max)
            {
                max = array[i];
            }
        }
        Console.WriteLine($"{max:F2} - {min:F2} = {max-min:F2}");
    }
}