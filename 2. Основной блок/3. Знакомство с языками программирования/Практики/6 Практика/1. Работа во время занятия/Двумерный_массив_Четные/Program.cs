/*В двумерном массиве n×k заменить четные элементы на противоположные*/

Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed1) Console.WriteLine("Пожалуйста введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int k);
if (!IsParsed2) Console.WriteLine("Пожалуйста введите натуральное число");


int[,] MultyArray = new int[n, k];

int[,] InitArray = GenerateArray(MultyArray);
PrintArray(InitArray);
int[,] ResultArr = ChangeArray(InitArray);
PrintArray(InitArray);


int[,] GenerateArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 100);
        }
    }
    return array;
}

int[,] PrintArray(int[,] array)
{

    Console.WriteLine();
    for (int u = 0; u < array.GetLength(0); u++)
    {
        Console.Write("[ ");
        for (int h = 0; h < array.GetLength(1); h++)
        {
            Console.Write($"{array[u, h]} ");
        }
        Console.Write("]");
        Console.WriteLine();
    }

    Console.WriteLine();
    return array;

}

int[,] ChangeArray(int[,] array)
{
    for (int y = 0; y < array.GetLength(0); y++)
    {
        for (int g = 0; g < array.GetLength(1); g++)
        {
            if (array[y, g] % 2 == 0)
            {
                array[y, g] = array[y, g] * -1;
            }
        }
    }
    return array;
}