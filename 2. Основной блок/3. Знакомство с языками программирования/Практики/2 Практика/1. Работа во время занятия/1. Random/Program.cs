// 9. Напишите программу которая выводит случайное число из отрезка и позывает наибольшую цифру числа

Random random = new Random();
int number = random.Next(10, 100);
int firstNumber = number / 10;
int lastNumber = number % 10;

Console.WriteLine(number);
if (firstNumber > lastNumber) Console.WriteLine(firstNumber);
else Console.WriteLine(lastNumber);

// var комбенированный тип данных для упрощения (чтобы не указывать каждый тип данных int, string)



