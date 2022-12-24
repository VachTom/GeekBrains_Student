/*Демонстрация решения 
Задача 31. Задайте массив из 12 элементов,
заполненный случайными числами из промежутка [-9, 9]
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
сумма положительных чисел равна 29,
сумма отрицательных чисел равна -20.  */

int [] array = GenerateArray(-9, 9, 12); //Отрезок от -9 до 9, 12 это число длины массива
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);

PrintArray();

Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}, Сумма отрицательных чисел = {sumNegativeNumbers}");



// Методы сумм отриц и полож элементов массива
int GetSumPositiveNumbersInArray(int [] array)
{
    int sumPositiiveNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>=0)
        {
           sumPositiiveNumbers += array[i];  
        }
    }
    return sumPositiiveNumbers;
}

int GetSumNegativeNumbersInArray(int [] array)
{
    int sumNegativeNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0)
        {
           sumNegativeNumbers += array[i];  
        }
    }
    return sumNegativeNumbers ;
}


// Метод создания массива
int[] GenerateArray(int min, int max, int length) // Метод который генерирует массив
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); 
    }
    return array;
}

// Метод чтобы вывести массив
void PrintArray()
{
    //Console.WriteLine("[{0}]",string.Join(", ", array)); // 1 вариант написания чтобы вывести
    for (var i = 0; i < array.Length; i++)                 // 2 вариант написания чтобы вывести
    {
        Console.Write($"{array[i]}");
    }
    string message = string.Join(", ", array);
    Console.WriteLine($"[{message}]");
}