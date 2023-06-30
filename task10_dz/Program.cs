/*
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int numberTwo = (userNumber % 100) / 10;
Console.Write(numberTwo);