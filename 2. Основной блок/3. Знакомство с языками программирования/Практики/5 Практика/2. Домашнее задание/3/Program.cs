﻿/*
1. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
2. Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

3. Написать программу копирования массива Clone()
*/




// 1 способ (Через цикл)
int[] arr = { 5, 4, 7, 2, 9 };

int[] copy = new int[arr.Length];
for (int i = 0; i < arr.Length; i++)
{
    copy[i] = arr[i];
}

Console.WriteLine(String.Join(", ", copy));        // 4, 7, 2


// 2 способ

int[] arr2 = { 5, 4, 7, 2, 9 };
int[] copy2 = new int[arr2.Length];
Array.Copy(arr, copy, arr.Length);

Console.WriteLine(String.Join(", ", copy));        // 5, 4, 7, 2, 9

