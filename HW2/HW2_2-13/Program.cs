// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

int FindThirdDigit1 (int num) //Вариант 1
{
     if (num < 100)
    {
        return -1;
    }

    while (num > 999)
    {
        num = num / 10;
    }
    
    return num % 10;
}


void FindThirdDigit2 (int num) //Вариант 2
{
     if (num < 100)
    {
        System.Console.WriteLine("Your number has not the third digit");
    }

    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
    
        System.Console.WriteLine($"The third digit is: {num % 10}");
    }
}


System.Console.Write("Input your number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

//System.Console.WriteLine(FindThirdDigit1(num)); // Для вариант 1

FindThirdDigit2(num); // Для варианта 2