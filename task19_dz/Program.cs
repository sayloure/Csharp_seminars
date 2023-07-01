/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
void palindrom(string number)
{
    int len = number.Length;
    if (len == 5)
    {
        if (number[0] == number[4] && number[1] == number[3])
        {
            Console.Write("Да");
        }
        else
        {
            Console.Write("Нет");
        }
    }
    else
    {
        Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
    }

}

Console.Write("Введите пятизначное число - ");
string userNumber = Console.ReadLine();
palindrom(userNumber);
