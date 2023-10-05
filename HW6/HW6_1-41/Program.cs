// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
public class HW6_1_41
{
    public static void Main(string[] args)
    {
        int M = new Random().Next(1,10);
        int [] massive = new int[M];
        InputMNum(massive);
        PrintArray(massive);
        Console.WriteLine($" -> {CountPositiveNum(massive)}");
    }
    public static void InputMNum(int[] array)
    {
        Console.WriteLine($"Input {array.Length} numbers: ");
 
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write($"{i+1} number: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    public static void PrintArray(int[] array)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if (i == 0)
            {
                Console.Write($"{array[i]}, ");
            }
            else if (i == array.Length - 1)
            {
                Console.Write($"{array[i]}");
            }
            else
            {
                Console.Write($"{array[i]}, ");
            }
        }
    }
    public static int CountPositiveNum(int[] array)
    {
        int result = 0;
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] > 0)
            {
                result++;
            }
        }
        return result;
    }
}