/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/* Мой вариант с методом(нерабочий)
int GetQuarter (int Quarter)
{
    int X = 0;
    int Y = 0;
    if (Quarter == 1)
    {
        X = +1;
        Y = -1;
    }
    else if (Quarter == 2)
    {
        X = -1;
        Y = +1;
    }
    else if (Quarter == 3)
    {
        X = -1;
        Y = -1;
    }
    else if (Quarter == 4)
    {
        X = +1;
        Y = -1;
    }
    return X;
    return Y;
}

Console.Write("Введите номер четверти - ");
int userQuarter = Convert.ToInt32(Console.ReadLine());

int XY = GetQuarter(userQuarter);
Console.Write(XY);
*/


/* Решение без метода
Console.Write("Введите номер четверти - ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1)
{
    Console.Write("X и Y > 0");
}
else if (quarter == 2)
{
    Console.Write("X < 0 и Y > 0");
}
else if (quarter == 3)
{
    Console.Write("X < 0 и Y < 0");
}
else if (quarter == 4)
{
    Console.Write("X > 0 и Y < 0");
}
*/

// Решение с методом
void GetQuarter(int quarter)   // если метод ничего не возвращает, то его тип void
{
    if (quarter == 1)
    {
        Console.Write("X и Y > 0");
    }
    else if (quarter == 2)
    {
        Console.Write("X < 0 и Y > 0");
    }
    else if (quarter == 3)
    {
        Console.Write("X < 0 и Y < 0");
    }
    else if (quarter == 4)
    {
        Console.Write("X > 0 и Y < 0");
    }
}

Console.Write("Введите номер четверти - ");
int userQuarter = Convert.ToInt32(Console.ReadLine());
GetQuarter(userQuarter);


