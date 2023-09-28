// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
class TestClass
{
    static void Main(string[] args)
    {
        // Display the number of command line arguments.
        Console.WriteLine(args.Length);
        int number = Convert.ToInt32(args[0]);

        if (number % 2 == 0)
        {
            System.Console.WriteLine($"Your number {number} is an even"); //even - четное
        } 
        else
        {
            System.Console.WriteLine($"Your number {number} is an odd"); //odd - нечётное
        }
    }
}