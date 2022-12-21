/*Задача 28: Напишите программу, которая принимает на вход число N
 и выдаёт произведение чисел от 1 до N.
4->24 
5->120*/


Console.WriteLine($"Введите число => ");

    bool isParsed = double.TryParse(Console.ReadLine(), out double n);
    if (!isParsed)
    {
        Console.WriteLine("Вы ввели некоректную информацию.");
        return;
    }
    else
    {
        double factorial = Factorial(n);
    }

Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");


double Factorial(double n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    return n*(Factorial(n - 1));
}



void test()
{
    double[] numbers = new double[] { 4, 5 };

    double[] expected = new double[] { 24, 120 };

    for (var i = 0; i < numbers.Length; i++)
    {
        double actual = Factorial(numbers[i]);

        if (actual != expected[i])
        {
            Console.WriteLine($"Ожидали получить {expected[i]} а получили {actual}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }
}
test();