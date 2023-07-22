﻿/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int Ackermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}





Console.Write("Введите значение m - ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение n - ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(m,n);

Console.Write($"m = {m}, n = {n} -> A(m,n) = {result}");

/*
A(m, n) = n + 1, если m = 0
A(m, n) = A(m - 1, 1), если m > 0 и n = 0
A(m, n) = A(m - 1, A(m, n - 1)), если m > 0 и n > 0
*/