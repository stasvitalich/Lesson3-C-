//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.
//Примеры:
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

//Инициируем ввод числа n
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"Таблица кубов от 1 до {n}: ");
for (int i = 1; i <= n; i = i + 1)
{   
    
    Console.WriteLine(Math.Pow(i, 3));
}
