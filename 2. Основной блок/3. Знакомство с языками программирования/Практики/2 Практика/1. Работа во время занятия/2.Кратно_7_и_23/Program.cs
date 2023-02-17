/*//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23. 
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

Код break экстренно остановаливает последующие действия только внутри циклов.
Код return экстренно остановаливает последующие действия только внутри методов.*/



//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
/*

Console.WriteLine("Введите значение точки х: ");
bool isParsedx = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedx) Console.WriteLine("Вы ввели не число, пожалуйста введите верное значение согласно условиям");

Console.WriteLine("Введите значение точки у: ");
bool isParsedy = int.TryParse(Console.ReadLine(), out int Y);
if (!isParsedy) Console.WriteLine("Вы ввели не число, пожалуйста введите верное значение согласно условиям");


if (X>0 && Y>0) Console.WriteLine("Точка находится в I четверти");
else if (X<0 && Y>0) Console.WriteLine("Точка находится в II четверти");
else if (X<0 && Y<0) Console.WriteLine("Точка находится в III четверти");
else (X>0 && Y<0) Console.WriteLine("Точка находится в IV четверти");


//Программа проверяет пятизначное число на палиндромом.


Console.WriteLine("Введите пятизначное число: ");
int n = int.Parse(Console.ReadLine());


for (int i = 0; i < length; i++)
{

}
*/

