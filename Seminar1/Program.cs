﻿//Найти наибольшее число массива

//int [] nums = new int [10] {1, 7, 8, 33, 24, 17, 2, 6, 4, 9};

//Обращение к конкретному элементу массива.
//Выйдет число 17, т.к. у него индекс 5
//int a = nums[5];
//Console.WriteLine(a);

//Введём новую переменную, пусть она будет максимальной.
//int max = nums[0];

//Если первое следующее число в массиве больше нашего максимального, 
//то следующее и есть максимальное. 
//Так вручную проверять каждое число можно, но очень долго, если чисел в массиве больше.
//if (nums[1] > max)
//{
//    max = nums[1];
//}

//Console.WriteLine(max);

//Давайте узнаем длину массива:
//Console.WriteLine(nums.Length);

//Если мы знаем, сколько раз нужно выполнить цикл, то используем for
int [] nums = new int [] {1, 7, 8, 33, 24, 17, 2, 6, 4, 9};
int max = nums[0];
for (int i = 0; i < nums.Length; i = i  + 1)
{
    if(nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine(max);