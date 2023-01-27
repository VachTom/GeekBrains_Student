/* Рекурсия Нахождение факториала
    Tип данных инт не поддерживает большое число при нахождении факториала
    Поможет тип данных double */
    
double Factorial(int n)
{
    //1! = 1
    //0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(16)); // 1*2*3 = 6
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}