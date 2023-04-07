/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Введите размер массива: ");   
int[] arr = new int[int.Parse(Console.ReadLine())];//Переменная которая задает размер массива
for (int i = 0; i < arr.Length; i++)      
{
    int k = int.Parse(Console.ReadLine());//Присваиваем значение каждой ячейки массива
    arr[i] = k;
}

void PrintArray(int[] arr)// Вывод на консоль массивЫ
{
    Console.WriteLine();
    Console.Write("[ ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write("]");
}


int[] reverse(int[] arr) //Создаем новый массив (Перевертыш) для будущего сравнения с первоначальным массивом
{
    int[] revArr = new int[arr.Length];//Создаем новый массив длинной ПАРАМЕТРА метода
    int reverseIndex = arr.Length - 1; // Ищем индекс последнего элемента P.S.  это последний индекс массива(.Length это начальная позиция массива; -1 перемещается индекс на последнюю позицию)

    for (int i = 0; i < arr.Length; i++)
    {
        revArr[i] = arr[reverseIndex];  // Присваиваем значение индекс нового массива, где значение будет последним элементом 
        reverseIndex = reverseIndex - 1; // И самое главное с каждым разом вычитвать - 1 чтобы reverseIndex не стоял на месте и не присваивался с каждым разом
    }
    return revArr;
}

int[] reverArray = reverse(arr);
void chek(int[]arr, int[]reverArray)
{ 
    if (arr == reverArray) Console.WriteLine("Данные являются Паллиндромом");
    else Console.WriteLine("Данные НЕ являются Паллиндромом");
}

PrintArray(arr);
PrintArray(reverArray);
Console.WriteLine();
Console.WriteLine();

chek (arr, reverArray);


/*
// палиндром
Console.Write("Введите размер паллиндрома: ");
bool IsParsed = int.TryParse(Console.ReadLine(), out int number);
if (!IsParsed) Console.WriteLine("Вы ввели не число, пожалуйста введите корректную информацию");


int[] GeneratArray()
{
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++) { }
    string print = string.Join(", ", array);
    Console.Write($"[{print}]");
}

int[] InitArray1 = GeneratArray();
PrintArray(InitArray1);

int[] InitArray2 = ReverseArray(InitArray1);
PrintArray(InitArray2);

//int[] ResultArr = ReverseArray(InitArray);

int[] ReverseArray(int[] arr)
{
    int reverseIndex = arr.Length-1;
    int[] RevArr = new int[arr.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        RevArr[i] = arr[reverseIndex];
        reverseIndex--;
    }
    return arr;
}*/