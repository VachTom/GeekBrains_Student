/*Показать числа Фибоначчи меньше заданного числа N, введённого с клавиатуры*/
Console.Write("Введите заданного число: ");
bool IsParsed = int.TryParse(Console.ReadLine(), out int number);



int num = 0;
int num2 = 1;
int save = 0;

while (num + num2 < number)
{
    save = num2;
    Console.WriteLine($"{num + num2}, ");
    num2+= num;
    num = save;
}

