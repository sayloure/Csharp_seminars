/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (number1 > number2 && number1 > number3)
{
    max = number1;
}
if  (number2 > number1 && number2 > number3)
{
    max = number2;
}
if  (number3 > number1 && number3 > number2)
{
    max = number3;
}
Console.Write(max);
