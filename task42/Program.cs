/*
Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/

// Вариант 1
/*
double DecimalToBinary(int dec)
{
    double bin = 0;
    int count = 0;
    while (dec > 0)
    {
        bin += dec % 2 * Math.Pow(10, count);
        dec /= 2;
        count++;
    }
    return bin;
}

Console.WriteLine(DecimalToBinary(123));
*/

// Вариант 2
void DecimalToBinary(string[] args)
{
    Console.Write("Введите десятичное число: ");
    int decimalNumber = Convert.ToInt32(Console.ReadLine());

    string binaryNumber = Convert.ToString(decimalNumber, 2);

    Console.WriteLine("Двоичное представление: " + binaryNumber);
}

DecimalToBinary(new string[0]);

