/* № 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно



Random rand = new Random();
int number1 = rand.Next(1, 1000000);
int number2 = rand.Next(1, 1000000);
*/



Console.WriteLine("Введите ПЕРВОЕ число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ВТОРОЕ число: ");
int number2 = Convert.ToInt32(Console.ReadLine());;

int remains = number1 % number2;




if (remains == 0) Console.WriteLine("Кратно");
else Console.WriteLine($"Не кратно, остаток: {remains}");

Console.WriteLine();
