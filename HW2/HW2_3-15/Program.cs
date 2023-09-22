// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

void WeekendOrNot(int num)
{
    if (num < 1 | num > 7)
    {
        System.Console.WriteLine("This day cannot be in a week");
    }
   
    if (num < 6 && num > 0)
    {
        System.Console.WriteLine("This is not weekend");
    }
        
    if (num > 5 && num < 8)
    {
        System.Console.WriteLine("This is weekend!");
    }
    
}

System.Console.Write("Input your day's number: ");
int dayNum = Convert.ToInt32(System.Console.ReadLine());

WeekendOrNot(dayNum);