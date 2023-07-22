/*
Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
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

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int FindMinRowSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = int.MaxValue;
    int minRowIndex = 0;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < columns; j++)
        {
            rowSum += array[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}



int[,] randomArray = GetRandom2DArray(4, 3, 0, 10);
Print2DArray(randomArray);
Console.WriteLine();
int minSumOfRows = FindMinRowSum(randomArray);
Console.Write($"Минимальная сумма элементов находится в {minSumOfRows} строке ");