/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число
в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation);

    }
    return result;
}

void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> ");
}

bool isNumberInArray(int [] randomArray, int Number)
{
    for(int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] == Number)
        return true; 
    }
    return false;
}

Console.WriteLine("Введите число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] randomArray = getRandomArray(10, 9);
printArray(randomArray);
if (isNumberInArray(randomArray, userNumber))
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}

