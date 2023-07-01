/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Введите число - ");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int coub = 0;

if (Num > 0)
{
    while (count <= Num)
    {
        coub = count * count * count;
        count = count + 1;
        Console.Write($"{coub}, ");
    }
}
else
{
    count = count * (-1);
    while (count >= Num)
    {
        coub = count * count * count;
        count = count - 1;
        Console.Write($"{coub}, ");
    }
}