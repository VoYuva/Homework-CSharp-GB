// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

public static class Exs66
{
    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(args[0]);
        int n = Convert.ToInt32(args[1]);
        Console.WriteLine($"M = {m}; N = {n} -> {RecSumElementsBetween(m, n)}");
    }
    public static int RecSumElementsBetween(int m, int n)
    {
        int result = 0;
        if(m == n)
        {
            return result += m;
        }
        else
        {
            return result += m + n + RecSumElementsBetween(m+1, n-1);
        } 
    }
}