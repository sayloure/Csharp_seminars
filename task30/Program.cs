/*
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

// Решение 1
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(0, 2);
}

PrintArray(arr);

// Решение 2
void fillRandomArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = rnd.Next(0, 2);
}

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[] randomArray = new int[8];
fillRandomArray(randomArray);
printArray(randomArray);