/*
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
Console.WriteLine($"Рандомное число - {randomNumber}");

int numberOne = randomNumber / 100 * 10;
int numberThree = randomNumber % 10;
int result = numberOne + numberThree;

Console.WriteLine(result);
