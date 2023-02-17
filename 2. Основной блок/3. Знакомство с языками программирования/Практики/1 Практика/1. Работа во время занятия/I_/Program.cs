// Даны два числа. Показать большее и меньшее число
Console.WriteLine("Введите Первое число: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите Второе число: ");
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    Console.WriteLine($"Число {a} больше числа {b}");
}
else
{
    Console.WriteLine($"Число {b} больше числа {a}");
}

        