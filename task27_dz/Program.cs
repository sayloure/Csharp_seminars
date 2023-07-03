/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

// Решение без метода
Console.Write("Введите число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = 0;
while (userNumber > 0)
{
    result = result + userNumber % 10;
    userNumber /= 10;
}

Console.WriteLine($"Сумма цифр в числе равна {result}");

/* Решение с методом
int GetSumOfNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number /= 10;
    }
    return result;
}

Console.Write("Введите число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр в числе равна {GetSumOfNumber(userNumber)}");
*/