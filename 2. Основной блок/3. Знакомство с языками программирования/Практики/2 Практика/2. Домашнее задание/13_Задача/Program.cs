/*  
    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6               */                                         
//                                                      ПЕРВЫЙ СПОСОБ
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Zadacha13(number);
void Zadacha13(string currentNumber)
{
        try
        {            Console.Write(currentNumber[2]); }
        catch
        {            Console.WriteLine("Третьей цифры/СИМВОЛА нет");}
        finally
        {
            Console.WriteLine();
            Console.WriteLine();
        }
}
//                                                       ВТОРОЙ СПОСОБ
//int number2 = Convert.ToInt32(Console.ReadLine()); 
//Zadacha13Alternativ(number2);


// Уважаемый преподаватель,  я понимаю что данное решение не эффективное. Тк очень много кода. И если бы был другой тип данных как long например было было все сложнее.
// Подскажите пожалуйста, как решить данную задачу с использованием цикла. Не могу установить закономерность((