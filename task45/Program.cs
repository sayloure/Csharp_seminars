/*
Напишите программу, которая будет создавать копию заданного одномерного массива 
с помощью поэлементного копирования.
*/

int[] copyArr(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

void printArray(int[] array, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] test = {1, 2, 3, 4, 5, 6};
printArray(test, "Изначальный");
int[] testCopy = copyArr(test);
printArray(testCopy, "Копия");