/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] GetRandom2Array(int rowNumber, int colNumber, int start, int end)
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

void PrintArithmeticMean(int[,] arrayToPrint)
{
    for (int j = 0; j < arrayToPrint.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arrayToPrint.GetLength(0); i++)
        {
            sum += arrayToPrint[i, j];
        }
        sum = sum / arrayToPrint.GetLength(0);
        sum = Math.Round(sum, 2);
        Console.Write(sum);
        if (j < arrayToPrint.GetLength(1) - 1)
            Console.Write("; ");
    }
}

int[,] randomArray = GetRandom2Array(3, 4, 0, 10);
Print2DArray(randomArray);
// int[,] testArray = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
// Print2DArray(testArray);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArithmeticMean(randomArray);

