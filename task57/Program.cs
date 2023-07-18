/*
Составить частотный словарь элементов двумерного массива. Частотный словарь 
содержит информацию о том, сколько раз встречается элемент входных данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
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

void CountElementsInArray(int[,] array, Dictionary<int, int> counter)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (counter.ContainsKey(array[i, j]))
            {
                counter[array[i, j]]++;
            }
            else
            {
                counter.Add(array[i, j], 1);
            }
        }
    }
}

Dictionary<int, int> counter = new Dictionary<int, int>();
int[,] randomArray = GetRandom2DArray(4, 5, 1, 9);
Print2DArray(randomArray);
CountElementsInArray(randomArray, counter);
Console.WriteLine();
foreach (int key in counter.Keys)
{
    if (key == 1)
    {
        Console.WriteLine($"{counter[key]} встречается {key} раз");
    }
    else
    {
        Console.WriteLine($"{key} встречается {counter[key]} раза");
    }

}
