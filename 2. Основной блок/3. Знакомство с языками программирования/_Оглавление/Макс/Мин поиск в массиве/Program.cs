Console.Clear();
int m = ReadInt("Введите размера одномерного массива: ");
int range = ReadInt("Введите диапазон значений одномерного массива от 0 до ");

int[] arr = new int[m];
int[] InitArray = GeneratArr(arr);
PrintArray(InitArray);

int[] FindMax = FindMaxElements(arr);
int[] FindMin = FindMinElements(arr);


int ReadInt(string input)
{
    Console.WriteLine(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write(" Пожалуйста, введите целое число.");
    return output;
}

int[] GeneratArr(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(range);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[] FindMaxElements(int[] array)
{
    int max = array[0];

    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] > max)
        {
            max = array[j];
        }
    }
    Console.WriteLine($"Максимальное значение = {max}");
    return array;
}

int[] FindMinElements(int[] array)
{
    int min = array[0];

    for (int j = 1; j < array.Length; j++)
    {
        if (array[j] < min)
        {
            min = array[j];
        }
    }
    Console.WriteLine($"Минимальное значение = {min}");
    return array;
}

