/*
 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

// Решение без метода
Console.Write("Введите число A - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < numberB; i++)
{
    result *= numberA;
}

Console.WriteLine($"{numberA} в степени {numberB} равно {result}");

/* Решение с методом
int GetDeegree(int A, int B)
{
    int result = 1;
    for(int i = 0; i < B; i++)
    {
        result *=A;
    }
    return result;
}

Console.Write("Введите число A - ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B - ");
int numberB = Convert.ToInt32(Console.ReadLine());

int deegree = GetDeegree(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} равно {deegree}");
*/
