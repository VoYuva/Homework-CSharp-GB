//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

System.Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    System.Console.WriteLine($"Max number is {num1}, min number is {num2}");
}
else
{
    System.Console.WriteLine($"Max number is {num2}, min number is {num1}");
}
