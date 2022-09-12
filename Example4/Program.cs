//Упорядочивание данных внутри массива

//Дан массив
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//Функция, позволяющая распечатать массив
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }   
    Console.WriteLine();
}
PrintArray(arr);

//Функция сортировки массива от большего к меньшему
void SelectionSort(int[] array)
{   //Перебираем все значения массива
    for(int i = 0; i < array.Length - 1; i++)
    {   //Допустим, что i - минимальное значение и вводим новую переменную
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {   //Если конкретное значение меньше минимального, то 
            //переназначаем минимальное значение
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }    
            //Обмен одной переменной через третью
            //Замена минимальной позиции с той, которую мы нашли
            int temporary = array[i];
            array[i] = array[minPosition];
            array[minPosition] = temporary;
        }
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);