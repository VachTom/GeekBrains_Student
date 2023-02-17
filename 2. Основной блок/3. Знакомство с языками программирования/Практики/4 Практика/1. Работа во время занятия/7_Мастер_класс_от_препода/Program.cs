void PrintArray(int[] array)
{
    foreach (int element in array)
        Console.Write($"{element} ");
    Console.WriteLine();
}
int[] CreateArray(int length, int lowest, int hightest)
{
    Random random = new Random();
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = random.Next(lowest, hightest + 1);
    return array;
}
bool Constains(int[] array, int value)
{
    foreach (int element in array)
        if (element == value)
            return true;
    return false;
}
int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}
int length = ReadInt("Enter size of array: ");
int lowest = ReadInt("Enter left part of array range: ");
int hightest = ReadInt("Enter right part of array range: ");
int[] array = CreateArray(length, lowest, hightest);
PrintArray(array);
int value = ReadInt("Enter element to find: ");
Console.WriteLine(Constains(array, value) ? "There is element into array" : "There is no element into array");



// Разные задачки
/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Не использовать готовые методы Min и Max
[3 7 22 2 78] -> 76*/




