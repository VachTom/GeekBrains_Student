/*Напишите программу , которая принимает на вход число (А) 
и выдает сумму чисел от 1 до А
7 -> 28
4 -> 10
8 -> 36 */

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
}