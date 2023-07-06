/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
отрицательные, и наоборот.

[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/

int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (int i = 0; i < length - 1; i++)
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
    Console.Write("] ->");
}

void negativePrintArray(int[] arrayToPrint)
{
     Console.Write(" [");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        arrayToPrint[i] *= -1;
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] randomArray = getRandomArray(4, 9);
printArray(randomArray);
negativePrintArray(randomArray);