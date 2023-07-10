/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/


int getCountOfNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

void userInputForArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число для элемента {i} - ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(" -> ");
}

Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[size];
userInputForArray(userArray);
int countOfNumbers = getCountOfNumbers(userArray);
printArray(userArray);
Console.Write(countOfNumbers);