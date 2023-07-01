/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09
A (7,-5); B (1,-1) -> 7,21
*/

Console.Write("Введите X для первой точки - ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y для первой точки - ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X для первой точки - ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y для первой точки - ");
int Y2 = Convert.ToInt32(Console.ReadLine());

int a = Y1 - Y2;
int b = X1 - X2;

double distance = Math.Sqrt(a * a + b * b);
Console.Write(distance);