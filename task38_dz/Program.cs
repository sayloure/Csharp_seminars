/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

double[] getRandomArray(int length, double deviation)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return result;
}

void printArray(double[] array)
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
    Console.Write("] => ");
}

double getMax(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double getMin(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] randomArray = getRandomArray(5, 100);
printArray(randomArray);
double max = getMax(randomArray);
double min = getMin(randomArray);
double diff = getMax(randomArray) - getMin(randomArray);
Console.Write($"{max} - {min} = {diff}");
