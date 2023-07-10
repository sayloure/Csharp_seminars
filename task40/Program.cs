﻿/*
Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
*/

bool IsTrianglePossible(int sideA, int sideB, int sideC)
{
    if ((sideA + sideB > sideC)
    && (sideB + sideC > sideA)
    && (sideC + sideA > sideB))
    {
        return true;
    }
    else
    {
        return false;
    }
}

if (IsTrianglePossible(3, 4, 5))
    System.Console.WriteLine("The triangle is possible.");
else
    System.Console.WriteLine("The triangle is impossible.");