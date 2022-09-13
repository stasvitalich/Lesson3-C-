//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти x, y

//Создаём метод, принимающий на вход целое число и возвращающий строку
string GetAreaRange(int areaNum)
{
    if (areaNum == 1)
    {
        return "x > 0, y > 0";
    }
      if (areaNum == 2)
    {
        return "x > 0, y < 0";
    }
      if (areaNum == 3)
    {
        return "x < 0, y < 0";
    }
      if (areaNum == 4)
    {
        return "x < 0, y > 0";
    }
    return "Номер четверти должен быть от 1 до 4";
}

//Инициализируем ввод числа
Console.Write("Введите номер четверти: ");
int areaNum = int.Parse(Console.ReadLine());

//Распечатываем метод через введение новой переменной
string result = GetAreaRange(areaNum);
Console.WriteLine(result);

