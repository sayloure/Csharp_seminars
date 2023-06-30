/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write("Введите число - ");
int userNumber = Convert.ToInt32(Console.ReadLine());

string numberThree = userNumber.ToString();
if (numberThree.Length > 2)
{
    Console.Write(numberThree[2]);
}
else
{
    Console.Write("Третьей цифры нет");
}