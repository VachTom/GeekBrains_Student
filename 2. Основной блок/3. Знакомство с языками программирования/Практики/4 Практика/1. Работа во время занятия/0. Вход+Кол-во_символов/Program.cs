
/*4П.1.0. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5 */
// тело программы
Console.WriteLine($"Введите число: ");
int number = InputInt();
Console.WriteLine($"Кол-во символов: {CountNumber(number)}");

// обьявление методов
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели некоректную информацию.");
        return -1;
    }
}

int CountNumber(int number)
{
    int count = 0;
    for (count = 0; number != 0; count++)
    {
        number = number % 10;
    }
    return count;
}
