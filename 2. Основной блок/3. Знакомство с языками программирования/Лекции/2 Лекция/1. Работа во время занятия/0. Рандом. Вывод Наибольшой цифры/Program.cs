//0. Рандом. Вывод Наибольшой цифры
/* 9. Напишите программу, которая выдает случайное число из отрезка [10, 99]
 и показывает наибольшую циaру числа 
пример: 78 - 8, 50 - 5, 13 - 3 */


Random rand  = new Random();
int number = rand.Next(10, 100);

Console.WriteLine(number);
int optim = number/10;
int optim2 = number%10;  

if (optim > optim2) Console.WriteLine(optim);
else if (optim < optim2) Console.WriteLine(optim2);
else Console.WriteLine("Числа равны");