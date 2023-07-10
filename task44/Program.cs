/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

Console.Write("Введите число N - ");
int N = Convert.ToInt32(Console.ReadLine());
int firstNum = 0;
int secondNum = 1;

void Fibonacci(int number)
{
    Console.Write("[");
    for (int i = 0; i < N; i++)
    {
        Console.Write(firstNum);
        if (i != N - 1)
        {
            Console.Write(", ");
        }
        int temp = firstNum;
        firstNum = secondNum;
        secondNum = temp + secondNum;
    }
    Console.Write("]");
}

Fibonacci(N);