//Напишите программу, которая принимает на вход координаты точки
//x и y (не равны нулю). Программа выдаёт номер четверти плоскости, 
//в которой находится точка
//Моё решение без использования методов

Console.WriteLine("Введите первую координату X отличную от 0");
int x = int.Parse(Console.ReadLine());
if (x == 0)
{
    Console.WriteLine("Координата должна быть больше 0");
    return;
}

Console.WriteLine("Введите вторую координату Y отличную от 0");
int y = int.Parse(Console.ReadLine());
if (y == 0)
{
    Console.WriteLine("Координата должна быть больше 0");
    return;
}

if (x > 0 & y > 0)
{
    Console.WriteLine("Точка находится в четверти 1");
}

if (x > 0 & y < 0)
{
    Console.WriteLine("Точка находится в четверти 2");
}

if (x < 0 & y < 0)
{
    Console.WriteLine("Точка находится в четверти 3");
}

if (x < 0 & y > 0)
{
    Console.WriteLine("Точка находится в четверти 4");
}