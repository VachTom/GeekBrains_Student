﻿/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 
-3; массив [6, 7, 19, 345, 3] -> да*/


int[] initiaArray = GenerateArray(-15,15,9);
PrintArray(initiaArray);
int [] resultArray = ChangeArray(initiaArray);
PrintArray(resultArray);


Console.WriteLine("Введите целое число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed)
{
    Console.WriteLine("Вы ввели некорректное значение.");
    return;
}
bool FindArray 



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

// Метод результата (меняем отрицательные на положит. И наоборот) 
int [] FindArray(int[] array)
{
   // int length = array.Length;
    int [] arr = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = -array[i]; 
    }
    return arr;
}

// Метод вынесения массив
void PrintArray(int[] array)  