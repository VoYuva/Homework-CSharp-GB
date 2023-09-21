// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа

int FindMiddleDigit(int num)
{
    if (num > 99 && num < 1000)
    {
        return (num / 10) % 10;
    }
    else
    {
        return -1;
    }    
}

System.Console.Write("Input your number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine(FindMiddleDigit(num));
