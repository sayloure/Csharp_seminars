/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Write("Введите X для первой точки - ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y для первой точки - ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z для первой точки - ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X для второй точки - ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y для второй точки - ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z для второй точки - ");
int Z2 = Convert.ToInt32(Console.ReadLine());

int a = Y1 - Y2;
int b = X1 - X2;
int c = Z1 - Z2;

double distance = Math.Sqrt(a * a + b * b + c * c);
Console.Write(distance);