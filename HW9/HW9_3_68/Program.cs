// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

public static class Exs68
{
    public static void Main(string[] args)
    {
        int m = Convert.ToInt32(args[0]);
        int n = Convert.ToInt32(args[1]);
        Console.WriteLine($"m = {m}, n = {n} -> A({m}, {n}) = {AckermanFunction(m, n)}");
    }
    public static int AckermanFunction(int m, int n)
    {
        if (m == 0) return n + 1;
        if (n == 0) return AckermanFunction(m - 1, 1);
        else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    }
}