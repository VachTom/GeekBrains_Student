/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */


// тело программы
Console.Write($"Введите число: ");
int number = InputInt();

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

int result = 0;
while (number > 0)
{
    int sum = number % 10;
    number = number / 10;
    result = result + number;
}

Console.WriteLine($"Сумма цифр в числе: {result}");
/*
Console.WriteLine("введите число");
int i = Convert.ToInt32(Console.ReadLine());

int sum = 0;
while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
*/






/*
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed || n < 1)
{
    Console.WriteLine("incorect number");
    return;
}

int sum = GetSumOfNumbersInInterval(n);
Console.WriteLine(sum);

int GetSumOfNumbersInInterval(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}*/