/*
1. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
2. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
3. В прямоугольной матрице найти строку с наименьшей суммой элементов.*/

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста, введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйстa, введите натуральное число");

if (m != n)
{
    int[,] MultyArray = new int[m, n];
    int[,] InitArray = GenerateArray(MultyArray);
    PrintArray(InitArray);
}
else Console.WriteLine("Матрица должна быть прямоуголной формы, просьба исправить размер Строки/Столбца");


int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) { array[i, j] = random.Next(1, 10); }
    }
    return array;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++) { Console.Write($"{arr[i, j]} "); }
        Console.Write("]");
        Console.WriteLine();
    }
}

