﻿/*
Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetAmountOfDigits(int num)
{
    int quantity = 0;
    while (num > 0)
    {
        num /= 10;
        quantity ++;
    }
    return quantity;
}


Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {number} -> {GetAmountOfDigits(number)}");