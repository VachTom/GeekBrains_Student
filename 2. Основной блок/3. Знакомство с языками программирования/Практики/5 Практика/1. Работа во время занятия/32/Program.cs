/*Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные,
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] initiaArray = GenerateArray(-15,15,9);
PrintArray(initiaArray);
int [] resultArray = ChangeArray(initiaArray);
PrintArray(resultArray);



// Метод создания массива
int[] GenerateArray(int min, int max, int length) // Метод который генерирует массив
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1); 
    }
    return array;
}

// Метод результата (меняем отрицательные на положит. И наоборот) 
int [] ChangeArray(int[] array)
{
   // int length = array.Length;
    int [] arr = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arr[i] = -array[i]; 
    }
    return arr;
}

// Метод вынесения массив
void PrintArray(int[] array)  
{
    Console.WriteLine(string.Join(", ", array));
}

