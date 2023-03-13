/*Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).*/



Console.Write("Введите размер строки: ");
bool IsParsed1 = int.TryParse(Console.ReadLine(), out int m);
if (!IsParsed1) Console.WriteLine("Пожалуйста, введите натуральное число");
Console.Write("Введите размер столбца: ");
bool IsParsed2 = int.TryParse(Console.ReadLine(), out int n);
if (!IsParsed2) Console.WriteLine("Пожалуйстa, введите натуральное число");

int[,] array = new int[m, n];

if (m > n || m < n) Console.WriteLine("Матрица не квадратная, к сожалению данное задание не выполнимо");
else
{
    int[,] GeneratArray(int[,] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(10, 100);
            }
        }
        return array;
    }

    void PrintArray(int[,] array)
    {
        Console.WriteLine();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        Console.WriteLine();
    }


    int[,] ReversArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = array[j, i];
            }
        }
        return array;
    }

    int[,] InitArray = GeneratArray(array);
    PrintArray(InitArray);
    int[,] InitArrayR = ReversArray(array);
    PrintArray(InitArrayR);

}