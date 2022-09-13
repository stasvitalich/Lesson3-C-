﻿//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//Пример: 
//14212 -> нет
//12821 -> да
//23432 -> да

//Создаём метод, который принимает на вход число,
//а возвращает строку.
string GetPolindrom (int number)

{   //При помощи математических операций, находим каждую из интересующих нас цифр числа.
    int first = number / 10000;
    int last = number % 10;
    int second = (number / 1000)%10;
    int penultimate = (number / 10)%10;

    //Если первая цифра равна последней и вторая цифра равна предпоследней,
    //то число является полиндромом.
    if(first == last & second == penultimate)
    {
        return "Да, число является полиндромом";
    }
    
    //Если предыдущее условие не выполняется, метод возвращает строку НЕТ
    return "Нет, число не является полиндромом";
}

//Инициализируем ввод пятизначного числа
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

//Загоняем пользователя в рамки условия задачи,
//чтобы мы получили именно пятизначное число
if (number > 99999)
{
    Console.WriteLine("Вы ввели слишком большое число, попробуйте снова");
    return;
} 

if (number < 10000)
{
    Console.WriteLine("Вы ввели слишком маленькое число, попробуйте снова");
    return;
}

//Вводим новую переменную и выводим метод
string result = GetPolindrom(number);
Console.WriteLine(result);

