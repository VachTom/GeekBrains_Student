// Сортировка пузырьком по парам от начала до конца массива 
//https://www.youtube.com/watch?v=bnfNSpB9HZQ

int[] A = new int[] { 5, 8, 9, 9, 8, 15, 98, 78, 0, 5 };

int[] InitArray = GenerateArray(A);
PrintArray(InitArray);


int[] GenerateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                int z = array[j];
                array[j] = array[j + 1];
                array[j + 1] = z;
            }
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int j = 0; j < arr.Length; j++) { Console.Write($"{arr[j]} "); }
    Console.Write("]");
    Console.WriteLine();
}
