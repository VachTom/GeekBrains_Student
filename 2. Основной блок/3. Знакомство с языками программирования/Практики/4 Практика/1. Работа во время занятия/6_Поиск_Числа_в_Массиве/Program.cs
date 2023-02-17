/*Задача 33: Задайте массив. Напишите программу, 
которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 
-3; массив [6, 7, 19, 345, 3] -> да*/

Console.Write("Введите число, которое хотите найти в массиве: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if (!isParsed) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию");


int[] InitArray = GeneratArray(-5, 5, 10);
PrintArray(InitArray);
int[] resultArray = FindNumberArray(InitArray);



int[] GeneratArray(int min, int max, int Length)
{
    int[] array = new int[Length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int []array)
{
    for (int i = 0; i < array.Length; i++) { }
    string mes = string.Join(", ", array);
    Console.WriteLine($"[{mes}]");
}
int[] FindNumberArray(int[] array)
{
    Console.WriteLine();
    int yes = 0;
    int no = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) yes++; 
        else  no++;                   
    }
    Console.WriteLine($"Число {number} в массиве присутствует {yes} раз");
    Console.WriteLine($"Число {number} в массиве НЕ присутствует {no} раз");
return array;
}
