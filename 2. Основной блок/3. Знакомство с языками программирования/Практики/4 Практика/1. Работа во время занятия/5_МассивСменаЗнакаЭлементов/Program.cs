/*Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные,
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] InitArray = GenerateArray(-100, 100, 5);
PrintArray(InitArray);
int[] ResultArray = ChangeArray(InitArray);
PrintArray(ResultArray);

//Array.Sort(array);
//int[] o = ChangeArray(array);
//Console.WriteLine(o);


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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { }
    string mes = string.Join(", ", array);
    Console.WriteLine($"[{mes}]");
}

int[] ChangeArray(int[] array)
{
    int[] arrays = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrays[i] += -array[i];
    }
    return arrays;
}