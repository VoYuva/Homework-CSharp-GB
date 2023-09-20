//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
System.Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

System.Console.WriteLine($"Max number is {max}");