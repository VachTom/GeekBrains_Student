// определить количество цифр в числе
/*

Console.WriteLine("Введите число А");
int numberA = int.Parse(Console.ReadLine());

for (int i = 0; i > numberA; i++)
{
    numberA = numberA / 10;
}
Console.WriteLine(i);*/

//2. Определить количество цифр в числе _01:50(Время семинара)
Console.Write("Введите число А:");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int A);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");

int i = 0; 
while (A != 0)
{
    i++;
    A = A / 10;
}

    Console.WriteLine(i);

//1. Возведите число А в натуральную степень B используя цикл/ 01:20
/*
Console.Write("Введите число А:");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int A);
if (!IsParsed1)
{
    Console.WriteLine("Пожалуйста введите натуральное число");
}

Console.Write("Введите число B:");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int B);
if (!IsParsed1)
{
    Console.WriteLine("Пожалуйста введите натуральное число");
}

int rezult = 1;
if (B>0)
{
    for (int i = 0; i < B; i++)
    {
        rezult= A*rezult;
    }
Console.WriteLine(rezult);
}
else Console.WriteLine("Степень должна быть положительной прошу вас ввести положительное число");

*/

