/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void fillRandomArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

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



Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());
if (size > 0)
{
    int[] randomArray = new int[size];
    fillRandomArray(randomArray);
    PrintArray(randomArray);
}
else if (size < 0)
{
    Console.WriteLine("Вы не можете ввести отрицательный размер массива!");
}
else
{
    Console.WriteLine("Размер массива должен быть больше 0!!!");
}




