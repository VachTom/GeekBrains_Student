﻿/*
"Существует несколько групп методов
1 вид методов: Ничего не принимают, Ничего не возвращают
2 вид методов: Что-то принимают, ничего не возвращают
3 вид методов: Ничего не принимают, Что-то возвращают
4 вид методов: Что-то принимают, что-то возвращают"    */

// 1 вид методов: Ничего не принимают, Ничего не возвращают
void Methood1()
{
    Console.WriteLine("Автор Товмасян Вачик Каренович");
}
Methood1();




// 2 вид методов: Что-то принимают, ничего не возвращают
void Methood2(string ads)
{
    Console.WriteLine(ads);
}
Methood2("Текст сообщения ");

//Именнованные аргументы, явно указывают к какому аргументу какое значение мы хотим указать. Далее разбор этого
//Это бывает нужно в том случае когда методы примают некоторое кол-во отличающих аргументов.
void Methood2_1(string ads, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(ads);
        i++;
    }
}
Methood2_1(ads: "Текст", count: 4);
//Methood2_1(count: 4, ads: "YjdsТекст");


// 3 вид методов: Ничего не принимают, Что-то возвращают
// возможность присвоить какой то переменной большое действие. Единсвтенное на что стоит обратить внимание в дальнейшем это создавать такие методы чтобы к ним больше не возращаться, либо смотреть что внутри метода находится и
int Methood3()
{
    return DateTime.Now.Year;
}
int year = Methood3();
Console.WriteLine(year);

/*
//4 вид методов: Что-то принимают, что-то возвращают"    */
string Methood4(int counts, string d)
{
    int i = 0;
    string result = string.Empty;

    while (i < counts)
    {
        result = result + d;
        i++;
    }
    return result;
}
string rew = Methood4(10, "asdf");
Console.WriteLine(rew);