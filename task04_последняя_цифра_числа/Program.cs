﻿/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает последнюю цифру этого числа
456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трёхзначное число");
int userInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(userInput % 10);