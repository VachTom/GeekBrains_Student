/*Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2 
89126 -> 5 */

/*Напишите программу , которая принимает на вход число (А) 
и выдает сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36 */
Console.WriteLine("Введите число => ");
bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
    return;
}

int sum = QuantityNumbers(n);
Console.WriteLine(sum);

int QuantityNumbers(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}