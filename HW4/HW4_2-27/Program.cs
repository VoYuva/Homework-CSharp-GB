// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

using System;

int SumOfDigitsInNumber (string Number)
{
    int num = int.Parse(Number);
    int result = 0;
    while (num > 0)
    {
        result+=(num%10);
        num/=10;
    }
    return result;
}

Console.Write("Please, input your number: ");
string number = Console.ReadLine()!;

Console.WriteLine($"The sum of the digits in your number {number} is equal to {SumOfDigitsInNumber(number)}");