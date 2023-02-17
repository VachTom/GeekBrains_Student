//                                  МАССИВЫ
/*                                  Теория. Console.WriteLine(string.Join("," array)); //Вывод массива через запятую 
Есть разные методы создания массива и в заимисимости от задачи применяют разные методы, для того что работать с этим массивом. (Изменить, использовать и т.д.).
Т.к массивы передаются по ссылке, нужно результат какого либо действия поместить в новый массив. А первоисточник оставить для, возможно последующего взаимодействия.
(Если метод меняет массив, он меняет его безвозратно)*/

/*3Л.1.4. Алгоритм Сортировки Методом Выбора
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
            if (array[j] < array[minPosition]) minPosition = j;
         }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;

    }

}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr); 
*/

/*4П.1.3. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]  
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
void TestPositiveGetSumOfNumbersInterval() //есть какая та ошибка 
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

/*5П.1.2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

*/

//3П.2.1. Паллиндроп. 1 Способ. Математический; 2 Способ. Через массив
/*
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

chek (arr, reverArray);*/

/*4П.1.2. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]
Найдите сумму отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]
сумма положительных чисел равна 29, сумма отрицательных чисел равна -20.  

int[] array = GenerateArray(-10, 10, 12); //Отрезок от -9 до 9, 12 это число длины массива
int sumPositiveNumbers = GetSumPositiveNumbersInArray(array);
int sumNegativeNumbers = GetSumNegativeNumbersInArray(array);
Array.Sort(array);
PrintArray();

Console.WriteLine($"Сумма положительных чисел = {sumPositiveNumbers}");
Console.WriteLine($"Сумма отрицательных чисел = {sumNegativeNumbers}");

int[] GenerateArray(int min, int max, int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
    }
    string mes = string.Join(", ", array);
    Console.WriteLine($"[{mes}]");
}

int GetSumPositiveNumbersInArray(int[] array)
{
    int sumPositiveNumbers = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositiveNumbers += array[i];
        }
    }
    return sumPositiveNumbers;
}

int GetSumNegativeNumbersInArray(int[] array)
{
    int sumNegativeNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegativeNumbers += array[i];
        }
    }
    return sumNegativeNumbers;
}
*/

//return DateTime.Now.Year; // Выводит текущий год 


//                              ДВУХМЕРНЫЕ МАССИВЫ
/*4Л.1.1. Освоение двухмерных массивов
/*
        string[,] table = new string[2, 5];

        table[1, 2] = "слово";
        for (int rows = 0; rows < 2; rows++)
        {
            for (int columns = 0; columns < 5; columns++)
            {
                Console.WriteLine($"-{ table[rows, columns]}-");
            }
        }


void PrintArray(int[,] matr)
{
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            Console.Write($"{matr[x, y]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)

{
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            matr[x,y] = new Random().Next(1,10); //[1, 10)
        }
     }
}

int[,] matrix = new int[4, 7];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
matrix[3, 5] = 39;
PrintArray(matrix);
*/

/*4Л.1.2. Создание рисунка
int[,] pic = new int[,]
{
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
 {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
 {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
 {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
};

//Закрашивание рисунка
void PrintImage(int[,] image)
{
    for (int x = 0; x < image.GetLength(0); x++)
    {
        for (int y = 0; y < image.GetLength(1); y++)
        {
            // Console.Write($"{image[x, y]} ");
            if (image[x, y] == 0) Console.Write($" ");
            else Console.Write($"1");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row-1, col);
        FillImage(row+1, col);
        FillImage(row, col-1);
        FillImage(row, col+1);
    }
}

PrintImage(pic);  //Вывод изначального рисунка
FillImage(14, 14);//Вывод решения

PrintImage(pic);  //Вывод нового рисунка

//Мы освоили ситуацию когда в методе вызываем метод (FiilImage)
//В программировании это называется рекурсией
*/



//                                  ЗНАЧЕНИЯ
/*2Л .1.3.Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно

Random rand = new Random();
int number1 = rand.Next(1, 1000000);
int number2 = rand.Next(1, 1000000);

Console.WriteLine("Введите ПЕРВОЕ число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int remains = number1 % number2;


if (remains == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток: {remains}");
Console.WriteLine();*/

/*4П.1.0. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе. 456 -> 3 78 -> 2 89126 -> 5
// тело программы
Console.WriteLine($"Введите число: ");
int number = InputInt();
Console.WriteLine($"Кол-во символов: {CountNumber(number)}");

// обьявление методов
int InputInt()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int number);
    if (isParsed)
    {
        return number;
    }
    else
    {
        Console.WriteLine("Вы ввели некоректную информацию.");
        return -1;
    }
}

int CountNumber(int number)
{
    int count = 0;
    for (count = 0; number != 0; count++)
    {
        number = number % 10;
    }
    return count;
}
 */

/*4П.1.1. Напишите программу , которая принимает на вход число (А) и выдает сумму чисел от 1 до А. ПРИМЕР: 7 -> 28; 4 -> 10; 8 -> 36 

bool isParsed = int.TryParse(Console.ReadLine(), out int n);
if (!isParsed || n < 1)
{
    Console.WriteLine("incorect number");
    return;
}

int sum = GetSumOfNumbersInInterval(n);
Console.WriteLine(sum);

int GetSumOfNumbersInInterval(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += i;
    }
    return sum;
}
*/

/*4П.1.2. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. ПРИМЕР: 4->24; 5->120 

Console.WriteLine($"Введите число => ");
    bool isParsed = double.TryParse(Console.ReadLine(), out double n);
    if (!isParsed)
    {
        Console.WriteLine("Вы ввели некоректную информацию.");
        return;
    }
    else
    {
        double factorial = Factorial(n);
    }

Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");

double Factorial(double n)
{
    if (n == 0 || n == 1)
    {
        return 1;
    }
    return n*(Factorial(n - 1));
}

void test()
{
    double[] numbers = new double[] { 4, 5 };

    double[] expected = new double[] { 24, 120 };

    for (var i = 0; i < numbers.Length; i++)
    {
        double actual = Factorial(numbers[i]);

        if (actual != expected[i])
        {
            Console.WriteLine($"Ожидали получить {expected[i]} а получили {actual}");
        }
        else
        {
            Console.WriteLine("okay");
        }
    }
}
test();
*/

/*4П.2.2. Свой Цикл возведения в степень. Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B.
Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow() ПРИМЕР: 3, 5 => 243; 2, 4 => 16

Console.Write($"Введите Первое число => ");
bool isParsed1 = int.TryParse(Console.ReadLine(), out int a);
if (!isParsed1)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
}
else
{
    Console.WriteLine();
}

Console.Write($"Введите Второе число => ");
bool isParsed2 = int.TryParse(Console.ReadLine(), out int b);
if (!isParsed2)
{
    Console.WriteLine("Вы ввели некоректную информацию.");
}
else
{
    int j = a;
    for (int i = 1; i < b; i++)
    {
        j = j* a;
    }
        Console.WriteLine();
        Console.WriteLine($"Число {a} в степени {b} = {j}");
} */

/*3Л.1.2. Напишите программой таблицу умножения используя цикл в цикле.
for (int i = 2; i <= 100; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i*j}");
    }
    Console.WriteLine();*/

/*4Л.1.3. Рекурсия Нахождение факториала
    Tип данных INT не поддерживает большое число при нахождении факториала
    Поможет тип данных double 
    
double Factorial(int n)
{
    //1! = 1
    //0! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.WriteLine(Factorial(16)); // 1*2*3 = 6
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

/*4Л.1.4. Рекурсия Формула Фибоначчи
//f(1)=1
//f(2)=1

//f(n)=f(n-1) + f(n-2)
int Fibonachi (int n)
{
    if (n == 1|| n==2) return 1;
    else return Fibonachi(n-1)+ Fibonachi(n-2);
}

for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Fibonachi(i)}");
}
*/




//                                  RANDOM
//int NumberA = new Random().Next(1, 25); //(Случайное число в массиве от 1 до 25)  => Console.WriteLine (NumberA);

/*2Л.1.0. Напишите программу, которая выдает случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. Пример: 78 - 8, 50 - 5, 13 - 3 

Random rand  = new Random();
int number = rand.Next(10, 100);

Console.WriteLine(number);
int optim = number/10;
int optim2 = number%10;  

if (optim > optim2) Console.WriteLine(optim);
else if (optim < optim2) Console.WriteLine(optim2);
else Console.WriteLine("Числа равны");
*/

/*2Л.1.2. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. НАПИСАНО ДВА МЕТОДА РЕШЕНИЯ

Random rand  = new Random();
int number = rand.Next(100, 1000);

Zadacha11(number);            //Обращение к методу Zadacha9 столько раз сколько хочешь.      
number = rand.Next(100, 1000);       
Zadacha11(number);            //Обращение к методу Zadacha9 столько раз сколько хочешь.             
number = rand.Next(100, 1000);

void Zadacha11(int currentNumber)     //f(x)
{
    Console.WriteLine();
    Console.WriteLine(currentNumber);
    int optim1 = currentNumber / 100; //Нахождение первого числа 
//  int optim2 = currentNumber % 100; //Нахождение второго и третьего числа (после можно найти только третье число)
    int optim3 = currentNumber % 10;  //Нахождение третьего числа 
    int rezult = optim1 * 10 + optim3;

    Console.WriteLine(rezult);
    Console.WriteLine();
}

//Второй метод 
Random rand  = new Random();
// int number = rand.Next(100, 1000);
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

Alternativa(number);  // Обращение к методу Zadacha9 столько раз сколько хочешь.      

void Alternativa(string currentNumber)//f(x)
{
    Console.WriteLine();
    Console.Write(currentNumber[1]); //первый индекс
    Console.Write(currentNumber[2]);
    Console.WriteLine();
    Console.WriteLine(" " + currentNumber[0] + currentNumber[2]);
} 

*/


/*4П.1.3. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0]  
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
void TestPositiveGetSumOfNumbersInterval() //есть какая та ошибка 
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





//                                  ТЕКСТ
/* Работа с текстом. Дан текст. В тексте нужно все пробелы заменит черточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить на маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли прситупом согласие прусского корля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

//string = s "qwerty"
//            012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i]== oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}


string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(text, 'С', 'с');
Console.WriteLine(newText); 
*/
