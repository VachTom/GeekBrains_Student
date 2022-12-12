/*
/*      Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6                                                        
//                                                      ПЕРВЫЙ СПОСОБ
                                            Console.WriteLine("Введите число: ");
//string number = Console.ReadLine();
//Zadacha13(number);
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
void Zadacha13Alternativ(int alteNumber)
{
   if      (alteNumber < 100)  Console.WriteLine("Третьей цифры нет.");

   else if (alteNumber < 1000)             Console.WriteLine(alteNumber % 10);
   else if (alteNumber < 10000)            Console.WriteLine(alteNumber % 100          / 10);
   else if (alteNumber < 100000)           Console.WriteLine(alteNumber % 1000         / 100);
   else if (alteNumber < 1000000)          Console.WriteLine(alteNumber % 10000        / 1000);
   else if (alteNumber < 10000000)         Console.WriteLine(alteNumber % 100000       / 10000);
   else if (alteNumber < 100000000)        Console.WriteLine(alteNumber % 1000000      / 100000);
   else if (alteNumber < 1000000000)       Console.WriteLine(alteNumber % 10000000     / 1000000);
   else if (alteNumber < 10000000000)      Console.WriteLine(alteNumber % 100000000    / 10000000);

   else if (alteNumber > 10000000000)      Console.WriteLine("Много лимонов");
}


/*      Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        645 -> 5
        78 -> третьей цифры нет
        32679 -> 6              


void Zadacha13Alternativa(int alteNumber)
{
    while(alteNumber < 100)
{





    Console.WriteLine("Третьей цифры нет.");
}
}
*


/*                                                                      Комментарий преподователя!!




void Zadacha13Alternativ(int alteNumber)
{
if (alteNumber < 100) Console.WriteLine("Третьей цифры нет.");

else if (alteNumber < 1000) Console.WriteLine(alteNumber % 10);
else if (alteNumber < 10000) Console.WriteLine(alteNumber % 100 / 10);
else if (alteNumber < 100000) Console.WriteLine(alteNumber % 1000 / 100);
else if (alteNumber < 1000000) Console.WriteLine(alteNumber % 10000 / 1000);
else if (alteNumber < 10000000) Console.WriteLine(alteNumber % 100000 / 10000);
else if (alteNumber < 100000000) Console.WriteLine(alteNumber % 1000000 / 100000);
else if (alteNumber < 1000000000) Console.WriteLine(alteNumber % 10000000 / 1000000);
else if (alteNumber < 10000000000) Console.WriteLine(alteNumber % 100000000 / 10000000);

else if (alteNumber > 10000000000) Console.WriteLine("Много лимонов");
} - так лучше не делать. Длина числа конечно ограничена размером типа, но что если там будет long лучше тоже самое сделать в цикле и уловить закономерность, кода будет меньше



В остальном все ок, только в 13) Что будет если число введут не трехзначным? а например 22

*/