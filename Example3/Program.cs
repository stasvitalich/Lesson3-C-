//Работа с текстом.
//Дан текст, в котором все пробелы нужно заменить чёрточками. 
//маленькие буквы "к" заменить большими "К"
//а большие "С" заменить маленькими "с"

string text = "Я думаю, - сказал князь, улыбаясь, - что,"
            + "если бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string text, char OldValue, char NewValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i= 0; i < length; i = i + 1)
    {
        if (text[i] == OldValue) result = result + $"{NewValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}            

string NewText = Replace(text, ' ', '|');
Console.WriteLine(NewText);
Console.WriteLine();

NewText = Replace(NewText, 'к', 'К');
Console.WriteLine(NewText);
Console.WriteLine();

NewText = Replace(NewText, 'С', 'с');
Console.WriteLine(NewText);
Console.WriteLine();
