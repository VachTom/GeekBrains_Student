//16. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.WriteLine("Введите ПЕРВОЕ целое число");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int number1);
if(!isParsed1)
{
    Console.WriteLine("Вы ввели не целое число. Пожалуйста, введите корректную информацию");
    return;
}
Console.WriteLine("Введите ВТОРОЕ целое число");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int number2);
if (!isParsed2)
{
    Console.WriteLine("Вы ввели не целое число. Пожалуйста, введите корректную информацию");
    return;
}
// Уверен что можно поместить этот метод одной строкой и меняя лишь переменную. Очень важный и удобный код

if (number1 == number2*number2) 
{
    Console.WriteLine($"Данное число {number1} является кврадратом числа {number2}");
}
else 
{
    if (number2 == number1*number1) 
    {
    Console.WriteLine($"Данное число {number2} является кврадратом числа {number1}");
    }
    else 
    {
        Console.WriteLine($"Числа НЕ является квадратом друг друга");
    }
}








/*
int number7 = number % 7;
int number23 = number % 23;

if (number7 == 0 && number23 == 0)
{
    Console.WriteLine($"Поздравляем! Число {number} кратно и на 7 и на 23");
}
else
{
    Console.WriteLine($"Сожалеем! Число {number} НЕ кратно и на 7 и на 23");
}

/*Код break экстренно остановаливает последующие действия только внутри циклов.
Код return экстренно остановаливает последующие действия только внутри методов.*/