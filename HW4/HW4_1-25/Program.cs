// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;

// const int A = 3;
// const int B = 5;

int NaturalDegree(int A, int B)
{
    int result = 1;
    for (int index = 0; index < B; index++)
    {
        result*=A; 
    }
    return result;
}

Console.Write("Input your number: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input your number of degree: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {A} to the natural degree {B} is equal to {NaturalDegree(A, B)}");
