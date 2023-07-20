/*
Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
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