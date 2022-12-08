int[] arr = { 5, 4, 9, 8, 2, 5, 15, 3, 5, 8, 7, 4, 6, 4 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
         {
            if (array[j] < array[minPosition]) minPosition = j
         }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);