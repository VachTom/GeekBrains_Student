//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива



int[] array = GenerateArray(-10, 10, 12); //Отрезок от -9 до 9, 12 это число длины массива
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);
Array.Sort(array);

PrintArray();

Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegativeNumbers}");


int[] GenerateArray(int min, int max, int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
    }
    string mes = string.Join(", ", array);
    Console.WriteLine($"[{mes}]");
}

int GetSumPositiveNumbersInArray(int[] array)
{
    int sumPositiveNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositiveNumbers += array[i];
        }
    }
    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int sumNegativeNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegativeNumbers += array[i];
        }
    }
    return sumNegativeNumbers;
}