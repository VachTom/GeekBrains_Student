int[] array = { 1, 2, 5, 8, 9, 6, 4, 45, 78, 98, 69, 63, 12, 45, 65, 78, 45 };

int n = array.Length;
int find = 78;


for (int index = 0; index < n; index++)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
}

