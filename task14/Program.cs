/*
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.Write("Введите число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber % 7 == 0 & userNumber % 23 == 0)
{
    Console.Write($"Число {userNumber} кратно 7 и 23");
}
else
{
    Console.Write($"Число {userNumber} не кратно 7 и 23");
}
