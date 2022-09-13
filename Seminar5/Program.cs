//Напишите программу, которая принимает на вход число N
//и выдаёт таблицу квадратов чисел от 1 до N

//Инициализируем ввод числа
Console.WriteLine("Введите число: ");
int initial = int.Parse(Console.ReadLine());

//Выводим все числа от 1 до N при помощи цикла for
for (int i = 1; i <= initial; i = i + 1)
{
    Console.WriteLine(Math.Pow(i, 2));
}