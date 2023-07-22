/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] GenerateRandomMatrix(int rows, int columns)
{
    Random rand = new Random();
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rand.Next(10);
        }
    }
    return result;
}

int[,] MultiplyMatrices(int[,] A, int[,] B)
{
    int rowsA = A.GetLength(0);
    int colsA = A.GetLength(1);
    int rowsB = B.GetLength(0);
    int colsB = B.GetLength(1);

    if (colsA != rowsB)
        throw new Exception("Недопустимый размер матрицы");

    int[,] result = new int[rowsA, colsB];

    for (int i = 0; i < rowsA; i++)
        for (int j = 0; j < colsB; j++)
            for (int k = 0; k < colsA; k++)
                result[i, j] += A[i, k] * B[k, j];

    return result;
}

void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = GenerateRandomMatrix(2, 2);
int[,] matrixB = GenerateRandomMatrix(2, 2);
int[,] result = MultiplyMatrices(matrixA, matrixB);

// int[,] matrixA = { { 2, 4 }, { 3, 2 } };
// int[,] matrixB = { { 3, 4 }, { 3, 3 } };
// int[,] result = MultiplyMatrices(matrixA, matrixB);

Console.WriteLine("Matrix A:");
PrintMatrix(matrixA);
Console.WriteLine("Matrix B:");
PrintMatrix(matrixB);
Console.WriteLine("Result:");
PrintMatrix(result);



