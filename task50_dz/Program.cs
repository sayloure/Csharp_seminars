/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetRandom2DArray(int rowNumber, int colNumber, int start, int end)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(start, end + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] array)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


int GetUserElement(int[,] array, int row, int col)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == array[row, col])
            {
                result = array[i, j];
            }
        }
    }
    return result;

}


int[,] randomArray = GetRandom2DArray(3, 4, 0, 10);
Print2DArray(randomArray);
Console.WriteLine();

Console.Write("Введите номер строки - ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонны - ");
int userCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (userRow < randomArray.GetLength(0) && userCol < randomArray.GetLength(1))
{
    int userElement = GetUserElement(randomArray, userRow, userCol);
    Console.Write(userElement);
}
else
{
    Console.WriteLine("Такого элемента нет");
}


