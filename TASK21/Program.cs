﻿//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//Формула для поиска искомого значения D=sqrt((X2-X1)^2 + (Y2-Y1)^2 + (Z2 - Z1)^2) 
//Примеры: 
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


//Создаем метод, который на вход принимает 6 целых чисел и возвращает double.
//При помощи формулы ищем d
double GetDistance (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double d = Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2);
    double squareRoot = Math.Sqrt(d);
    return squareRoot;
}

//Инициализируем ввод координат двух точек
Console.WriteLine("Введите координату Х точки 1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 1: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Х точки 2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z точки 2: ");
int z2 = int.Parse(Console.ReadLine());

double final = GetDistance (x1, x2, y1, y2, z1, z2);
Console.WriteLine($"Расстояние между точками в 3D пространстве составляет: {Math.Round(final, 2, MidpointRounding.ToNegativeInfinity)}");
