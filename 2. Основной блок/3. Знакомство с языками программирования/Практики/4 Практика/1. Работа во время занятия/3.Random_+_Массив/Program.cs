/*Задача 30: 
Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]  */

Random rnd = new Random();


bool isParsed = int.TryParse(Console.ReadLine(), out int num);
if (!isParsed)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
    return;
}
else
{
    int userLength = num;

    int[] userArray = ArrayFilling(userLength);
    PrintArr(userArray);

    int[] ArrayFilling(int userLength)
    {
        int[] arr = new int[userLength];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, 2); // промежуток от 0 до двух
        }
        return arr;
    }

    void PrintArr(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}


/*есть какая та ошибка 

void TestPositiveGetSumOfNumbersInterval()
{
    int[] numbers = new int[] { 1, 2, 3, 4 };

    int[] expected = new int[] { 1, 3, 6, 10 }; // expected - это то что мы ожидаем получить от метода

    for (int i = 0; i < numbers.Length; i++)
    {
        int actiol  = TestPositiveGetSumOfNumbersInterval(numbers[1]); //actiol 
        if (actiol != expected[i])
        {
            Console.WriteLine($"Ожидали получить {expected[i]} а получили {actiol}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }
}*/