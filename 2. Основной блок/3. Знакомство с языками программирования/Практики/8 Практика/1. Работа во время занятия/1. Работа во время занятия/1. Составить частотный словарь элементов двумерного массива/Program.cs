/* Составить частотный словарь элементов двумерного массива

Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
Пример: Есть набор данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }

частотный массив может быть представлен так:

0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза */

/*
Если набор данных - таблица
1, 2, 3
4, 6, 1
2, 1, 6

на выходе ожидаем получить
1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза

Пример частотного массива для текстовых данных: Входные данные:

Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального 
статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, 
которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.

Частотный анализ может выглядеть так

Символ пробел/space встречается 41 раз. Част*/



Console.Clear();
int m = ReadInt("Введите размер массива: ");
int range = ReadInt("Введите диапазон массива от 1 до ");


/*
List<T> removeDuplicates<T>(List<T> list)
{
    return new HashSet<T>(list).ToList();
}
void Main()
{
    List<int> array = new List<int> { 2, 3, 3, 4, 1, 2, 5 };
    List<int> distinct = removeDuplicates(array);

    Console.WriteLine(String.Join(",", distinct));
}*/
int[] array = new int[m];
int[] InitArray = GenerateArray(array);
PrintArray(InitArray);
int[] ResultArray = FindArr(InitArray);

int[] GenerateArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(range);
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

int ReadInt(string input)
{
    Console.WriteLine(input);
    bool IsParsed = int.TryParse(Console.ReadLine(), out int output);
    if (!IsParsed) Console.Write("Пожалуйста, введите натуральное число");
    return output;
}

int[] FindArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int findElements = array[i];
        int findCount = 1;
        int temp = 1;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (findElements == array[j])
            {
                findCount += 1;
                temp = findCount;
                
            }
        }
        Console.WriteLine($"Число {findElements} встречается {temp} раз");
    }
    return array;
}





/*
void Distinct(int[] source, int target)
{
    // checks skipped
     //distinctCache.Clear();
    var copyIndex = 0;
    for (var i = 0; i < source.Length; i++)
    {
        
    var s = source[i];
        if (!s)
            target[copyIndex++] = source[i];
    }
}*/