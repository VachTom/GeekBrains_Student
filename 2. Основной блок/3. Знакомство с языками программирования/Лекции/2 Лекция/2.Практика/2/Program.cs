/*int[] array = new int[10];
Console.WriteLine("0 1 2 3 4 5 6 7 8 9");
void FullArray(int[] coolection)
{
    for (int index = 0; index < coolection.Length; index++)
    {
        coolection[index] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] coll)
{
    for (int index = 0; index < coll.Length; index++)
    {
        Console.Write(coll[index] + " ");
    }
}
int Index0f(int[] colection, int find)
{
    int position = 0;

    for (int index = 0; index < colection.Length; index++)
    {
        if (colection[index] == find)
        {
            position = index;
            break;
        }
    }
    return position;
}


array[4] = 2;
array[8] = 2;

FullArray(array);
PrintArray(array);

Console.WriteLine();


int pos = Index0f(array, 2);
Console.WriteLine(pos);
*/

Console.WriteLine("0 1 2 3 4 5 6 7 8 9");
int[] array = new int[10];

void FullArray(int[] collection)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 10);        
    }
}

void PrintArray(int[] coll)
{ 
for (int i = 0; i < coll.Length; i++)
{
    Console.Write(array[i]+ " ");
}
}

int Index0f(int[] collection, int find)
{
    int position = 0;
    for (int i = 0; i < collection.Length; i++)
    {
        if (collection[i] == find)
        {
            position= i;
            break;
        }
    }
    return position;
}

FullArray(array);
PrintArray(array);

int n = Index0f(array, 2);
Console.WriteLine();
Console.WriteLine(n);