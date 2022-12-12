/* Возврощаемый тип данных НазваниеМетода()
 Тело метода
{
    return 1; оператор return возвращает из метода значение и останавливает его. 
}*/

Console.Write("Введите значение x ==> ");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);
Console.Write("Введите значение y ==> ");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if (!isParsedX || !isParsedY)
{
    Console.WriteLine($"Координаты ввели не корректно");
    return;
}

/*
Метод Void применяется зачастую тогда, когда мы в методе никакого результата не получаем.
Просто выводит результат в консоль. Примеры: состовление массива.

Если мы, к примеру, посчитали какое то уравнение, применив метод Void, 
мы не сможем применять этот результат в дальнейшем нашем уравнении. 
Метод Void покажет результат только в терминале 
*/


int GetQuarteryByCoordinates(int x, int y) //Сам метод
{
    if (x > 0 && y > 0)
    {
        return 1;
    }

    if (x < 0 && y > 0)
    {
        return 2;
    }

    if (x < 0 && y < 0)
    {
        return 3;
    }

    if (x > 0 && y < 0)
    {
        return 4;
    }
    return -1;
}


int quarterNumber = GetQuarteryByCoordinates(x, y); //Выводим метод
if (quarterNumber == -1) // в том случае когда никакое условие не подошло в методе, Последнее значение:(return = -1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}
Console.WriteLine(quarterNumber);
/*
Задача 18. Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (х и у).
*/