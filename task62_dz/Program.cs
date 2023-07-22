/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void FillSpiral(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);
    int row = 0, col = 0, dx = 1, dy = 0;
    int temp;

    for (int i = 1; i <= rows * cols; i++)
    {
        array[row, col] = i;
        if (array[(row + dy + rows) % rows, (col + dx + cols) % cols] != 0)
        {
            temp = dx;
            dx = -dy;
            dy = temp;
        }
        row += dy;
        col += dx;
    }
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j].ToString("D2") + " ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
FillSpiral(array);
PrintMatrix(array);