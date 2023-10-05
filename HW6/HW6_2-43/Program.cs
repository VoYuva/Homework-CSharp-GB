// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System;
public class HW6_2_43
{
    public static void Main(string[] args)
    {
        double[] b1k1b2k2 = new double[4];
        InputLineArg(b1k1b2k2);
        Console.Write($"b1 = {b1k1b2k2[0]}, k1 = {b1k1b2k2[1]}, b2 = {b1k1b2k2[2]}, k2 = {b1k1b2k2[3]} -> ");
        IntersectionPoint(b1k1b2k2);
    }
    public static void InputLineArg(double[] array)
    {
        int i = 0;
        while(i < 4)
        {
            if(i == 0)
            {
                Console.Write("b1 = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            else if (i == 1)
            {
                Console.Write("k1 = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            else if (i == 2)
            {
                Console.Write("b2 = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            else if(i == 3)
            {
                Console.Write("k2 = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            i++;
        }
    }
    public static void IntersectionPoint(double[] array)
    {
        double x, y;
        x = (array[2] - array[0]) / (array[1] - array[3]);
        y = array[1] * x + array[0];
        Console.WriteLine($"({x:F1}; {y:F1})");
    }
}
