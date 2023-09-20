// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

System.Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    System.Console.WriteLine($"Your number {number} is an even"); //even - четное
} 
else
{
    System.Console.WriteLine($"Your number {number} is an odd"); //odd - нечётное
}