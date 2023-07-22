/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

void NaturalNumbers(int userN, int count = 1)
{
    if (userN < count)
    {
        return;
    }
    else
    {
        Console.Write(count + " ");
        NaturalNumbers(userN, count + 1);
    }
}

int n = 5;
NaturalNumbers(n);