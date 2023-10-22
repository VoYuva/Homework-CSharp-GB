// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

public static class Exs64
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(args[0]);
        Console.WriteLine($"N = {n} -> '{RecFromNto1(n)}'");
    }
    public static string RecFromNto1(int n)
    {
        if(n == 1)
        {
            return "1";
        }
        else
        {
            return $"{n}, {RecFromNto1(n-1)}";
        } 
    }
}