//Напишите программу, которая на входе принимает
//координаты двух точек и находит расстояние между ними в 2D пространстве.
//Формула для поиска искомого значения d = √ [(x2-x1)2+ (y2-y1)2], Где (x1, y1) и (x2, y2) 
//Пример: А(3,6); В(2,1) => 5.09
//Как вычислено: х1 = 3, х2 = 2, у1 = 6, у2 = 1.
//D = 5.09

//Создаем метод, который на вход принимает 4 целых числа и возвращает double.
//При помощи формулы ищем d
double result (int x1, int x2, int y1, int y2)
{
    double d = Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2);
    double squareRoot = Math.Sqrt(d);
    return squareRoot;
}

//Инициализируем ввод координат двух точек
Console.WriteLine("Введите координату Х точки 1: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 1: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Х точки 2: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y точки 2: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Точка 1: {x1},{y1}");
Console.WriteLine($"Точка 2: {x2},{y2}");

double final = result (x1, x2, y1, y2);
Console.WriteLine(final);

