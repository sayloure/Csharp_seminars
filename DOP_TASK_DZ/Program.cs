/*
Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих.
3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

void GenerateSequence(int first, int second, int N)
{
    Console.Write(first + " " + second + " ");
    int next;
    for (int i = 2; i < N; i++)
    {
        next = first + second;
        Console.Write(next + " ");
        first = second;
        second = next;
    }
    Console.WriteLine();
}

Console.Write("Введите первое число - ");
int userFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число - ");
int userSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N - ");
int userN = Convert.ToInt32(Console.ReadLine());

GenerateSequence(userFirst, userSecond, userN);