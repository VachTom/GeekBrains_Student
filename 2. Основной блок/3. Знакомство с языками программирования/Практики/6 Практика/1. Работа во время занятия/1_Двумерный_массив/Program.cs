/*Показать двумерный массив размером m×n заполненный целыми числами*/


Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");

Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйста введите натуральное число");

Console.Write("Введите коэффициент масштабирования: ");
bool IsParsed3 = int.TryParse(Console.ReadLine(), out int k);
if (!IsParsed3) Console.WriteLine("Пожалуйста введите натуральное число");



int[,] GenerateArray(int [,]array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1, 100);
        }
    }
return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int w = 0; w < array.GetLength(0); w++)
    {
        Console.Write("[ ");
        for (int q = 0; q < array.GetLength(1); q++)
        {
            Console.Write($"{array[w,q]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int[,] CoefArray(int[,] array)
{
    for (int c = 0; c < array.GetLength(0); c++)
    {
        for (int w = 0; w < array.GetLength(1); w++)
        {
            array[c, w] *= k;
        }
    }
    return array;
}



int[,] marray = new int [m, n];

int[,] InitArray = GenerateArray(marray);
PrintArray(InitArray);

int[,] arra = CoefArray(marray);
PrintArray(arra);
