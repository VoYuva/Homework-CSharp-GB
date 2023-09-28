// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

const int twoNumbersMinValue = 100;
const int twoNumbersMaxValue = 999;
const int divider = 10;


// int FindThirdDigit1 (int num) //Вариант 1
// {
//      if (num < twoNumbersMinValue)
//     {
//         return -1;
//     }

//     while (num > twoNumbersMaxValue)
//     {
//         num = num / divider;
//     }
    
//     return num % divider;
// }


void FindThirdDigit2 (int num) //Вариант 2
{
     if (num < twoNumbersMinValue)
    {
        System.Console.WriteLine("Your number has not the third digit");
    }

    else
    {
        while (num > twoNumbersMaxValue)
        {
            num = num / divider;
        }
    
        System.Console.WriteLine($"The third digit is: {num % divider}");
    }
}


System.Console.Write("Input your number: ");
int num = Convert.ToInt32(System.Console.ReadLine());

//System.Console.WriteLine(FindThirdDigit1(num)); // Для вариант 1

FindThirdDigit2(num); // Для варианта 2