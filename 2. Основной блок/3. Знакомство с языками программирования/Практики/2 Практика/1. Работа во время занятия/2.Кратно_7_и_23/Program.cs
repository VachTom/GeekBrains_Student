//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
//14 -> нет 46 -> нет 161 -> да
Console.WriteLine("Введите целое число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Вы ввели не целое число. Пожалуйста, корректную информацию");
    return;
}
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