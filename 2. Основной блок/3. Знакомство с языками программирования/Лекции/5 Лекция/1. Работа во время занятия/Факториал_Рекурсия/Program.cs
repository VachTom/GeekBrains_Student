// Факториал числа с использованием Рекурсией 

double Factorial(int n)
{
    // 1! = 1;
    // 0! = 1;
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}

Console.WriteLine(Factorial(6));

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}