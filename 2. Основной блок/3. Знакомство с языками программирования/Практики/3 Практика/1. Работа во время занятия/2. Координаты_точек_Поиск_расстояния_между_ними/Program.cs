/*
Задача 21: Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
*/


//using static Console;	// Позволяет не не прописывать команду (для лентяев)))

double InputInt()
{
    bool isNum = double.TryParse(Console.ReadLine(), out double num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некоретное значение");
        return -1;
    }
}
double ax = InputInt();
double ay = InputInt();
double bx = InputInt();
double by = InputInt();

double ab = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
Console.WriteLine(ab);

/*
//прописали методом
double GetDistanceBetweenTwoPoints(double ax, double ay, double bx, double by)
{
double ab = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
return ab;
}
//прописали методом Более красиво
double GetDistanceBetweenTwoPoints1(int x1, int x2, int y1, int y2)
{
return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
}
*/