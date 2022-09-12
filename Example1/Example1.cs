//Вид 1. Ничего не принимает и ничего не возвращает.
void Method1()
{
    Console.WriteLine("Автор Станислав Князев");
}
Method1();


//Вид 2. Что-то принимает, но ничего не возвращает.
//Пример, когда аргумент один
void Method2(string blog)
{
    Console.WriteLine(blog);
}

Method2("Текст сообщения");

//Пример, когда аргументов больше
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i = i + 1;
    }
}

Method21(msg: "Текст", count: 5);


//Вид 3. Ничего не принимает, но что-то возвращает. 

int Method3()
{
    return DateTime.Now.Year;
}

int result = Method3();
Console.WriteLine(result);


//Вид 4. Что-то принимает и что-то возвращает.

string Method4 (int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while(i < count)
    {
        result = result + text;
        i = i + 1;
    }
    return result;
}
string words = Method4(10, "gbcz");
Console.WriteLine(words);


//Цикл for

string Method5 (int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i = i + 1);
    {
        result = result + text;
    }
    return result;
}
string results = Method4(10, "gbcz");
Console.WriteLine(words);
