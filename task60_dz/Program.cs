/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/





int[,,] GenerateUniqueArray(int x, int y, int z)
{
    Random rand = new Random();
    int[,,] result = new int[x, y, z];
    List<int> usedNumbers = new List<int>();

    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                int number;
                do
                {
                    number = rand.Next(10, 100);
                } while (usedNumbers.Contains(number));
                usedNumbers.Add(number);
                result[i, j, k] = number;
            }

    return result;
}

void PrintArray(int[,,] array)
{
    int x = array.GetLength(0);
    int y = array.GetLength(1);
    int z = array.GetLength(2);
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ")");
            }
            Console.WriteLine();
        }
    }
}


int[,,] array = GenerateUniqueArray(2, 2, 2);
PrintArray(array);
