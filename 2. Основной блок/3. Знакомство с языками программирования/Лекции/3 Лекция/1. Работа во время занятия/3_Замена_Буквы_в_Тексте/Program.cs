/*Работа с текстом
Дан текст.  В тексте нужно все пробелы заменит черточками,
маленькие буквы "к" заменить большими "К"
А больше "С" заменить на маленькие "с".
*/
string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли прситупом согласие прусского корля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string = s "qwerty"
//            012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText); 
