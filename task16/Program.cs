/*
Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.Write("Введите число - ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число - ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

/*
Решение 1
if (numberOne / numberTwo == numberOne || numberTwo / numberOne == numberTwo || numberOne / numberTwo == numberTwo || numberTwo / numberOne == numberOne)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
*/

// Решение 2
if (numberOne * numberOne == numberTwo || numberTwo * numberTwo == numberOne)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}