//Напишите программу, которая принимает на вход координаты точки
//x и y (не равны нулю). Программа выдаёт номер четверти плоскости, 
//в которой находится точка
//Решение на семинаре

//Создаём метод, принимающий на вход 2 числа и возвращающий целое число
int GetPointArea(int x, int y)
{
    if (x > 0 & y > 0)
    {
        return 1;
    }
    
    if (x > 0 & y < 0)
    {
        return 2;
    }

   if (x < 0 & y < 0)
    {
        return 3;
    }

    if (x < 0 & y > 0)
    {
        return 4;
    }
        return 0;
}
//Вводим число
Console.WriteLine("Введите число x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число y");
int y = int.Parse(Console.ReadLine());

//Создаём переменную, чтобы вывести на экран наш метод
int areaNum = GetPointArea(x, y);
Console.WriteLine($"Area = {areaNum}");
