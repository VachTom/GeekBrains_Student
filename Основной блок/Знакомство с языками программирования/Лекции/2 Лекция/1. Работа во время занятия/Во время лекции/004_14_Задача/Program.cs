/*
 № 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да


Console.WriteLine("Введите ПЕРВОЕ число: ");
int number = Convert.ToInt32(Console.ReadLine());

int remains1 = number % 7;
int remains2 = number % 23;

if (remains1 == 0 && remains2 == 0) Console.WriteLine("Да, кратно");
else Console.WriteLine($"Нет, не кратно");

Console.WriteLine();



//Альтернатива
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 7 == 0) Console.WriteLine("Да, кратно");
else Console.WriteLine($"Нет, не кратно");

Console.WriteLine();

 
*/
