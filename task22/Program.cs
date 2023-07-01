/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/
// Решение 1
Console.Write("Введите число - ");
int Num = Convert.ToInt32(Console.ReadLine());
int count = 1;
int sqrt = 0;

if (Num > 0)
{
    while (count <= Num)
    {
        sqrt = count * count;
        count = count + 1;
        Console.Write($"{sqrt}, ");
    }
}
else
{
    count = count * (-1);
    while (count >= Num)
    {
        sqrt = count * count;
        count = count - 1;
        Console.Write($"{sqrt}, ");
    }
}


//Решение 2
string Squares(int n)
{
    string squares = "1";
    if (n > 2)
    {
        for (int i = 2; i <= n; i++)
        {
            squares = $"{squares} {i * i}";

        }
    }
    else
    {
        for (int i = 0; i >= n; i--)
        {
            squares = $"{squares} {i * i}";
        }
    }
    return squares;
}
Console.Write("Введите число - ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Squares(number));