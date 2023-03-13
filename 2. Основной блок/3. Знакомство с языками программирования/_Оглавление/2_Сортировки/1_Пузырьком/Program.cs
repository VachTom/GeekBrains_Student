// Сортировка пузырьком по парам от начала до конца массива 
//https://www.youtube.com/watch?v=bnfNSpB9HZQ

Console.Clear();
int m = ReadInt("Введите значение строки: ");
//int n = ReadInt("Введите значение столбца: ");
int range = ReadInt("Введите диапазон чисел от 1 до ");

int[] array = new int[m];
GeneratArray(array);
PrintArray(array);
int[] ResultArray = MinArray(array);
PrintArray(ResultArray);

int[] GeneratArray(int[] array)
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
    Console.WriteLine();  
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int ReadInt(string input)
{
    Console.Write(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write(" Пожалуйста, введите натуральное число");
    return output;
}

int[] MinArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j+1] < array[j])
            {
                int c = array[j];
                array[j] = array[j+1];
                array[j+1] = c;
            }
        }
    }
    return array;
}