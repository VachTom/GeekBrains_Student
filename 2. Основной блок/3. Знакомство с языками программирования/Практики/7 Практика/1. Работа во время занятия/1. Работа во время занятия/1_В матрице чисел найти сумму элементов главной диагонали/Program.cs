﻿/*В матрице чисел найти сумму элементов главной диагонали*/

int[,] GeneratArray(int value)
{
    int[,] table = new int[value, value];
    Random random = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = random.Next(1, 10);
        }
    }
    return table;
}

void PrintArray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int SumMatrikDiog(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int value = ReadInt("Введите размер матрицы: ");
int[,] InitArr = GeneratArray(value);
PrintArray(InitArr);
Console.WriteLine($"Сумма элементов главной диагонали: {SumMatrikDiog(InitArr)}");