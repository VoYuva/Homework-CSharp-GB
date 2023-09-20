// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

System.Console.Write("Enter your number, which should be greater than 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2; //Так как 1 все равно не чётное и ен будет отображаться, то и смысла начинать с него нет.

while (count <= N && N > 1)
{
    if (count == 2) System.Console.Write(count); 
    if (count % 2 == 0 && count != 2)//Для красивой записи с запятыми в результате
    {
        System.Console.Write($", {count}");
    }
    count++;
}

if (N <= 1) System.Console.WriteLine("Your number is not correct. Try again with the correct number.");