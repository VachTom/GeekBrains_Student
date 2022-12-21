/*           Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 

Random rand  = new Random();
int number = rand.Next(100, 1000);

Zadacha11(number);                    //      Обращение к методу Zadacha9 столько раз сколько хочешь.      
number = rand.Next(100, 1000);       
Zadacha11(number);                    //      Обращение к методу Zadacha9 столько раз сколько хочешь.             
number = rand.Next(100, 1000);



void Zadacha11(int currentNumber)     //      f(x)
{
    Console.WriteLine();
    Console.WriteLine(currentNumber);
    int optim1 = currentNumber / 100;        //      Нахождение первого числа 
//  int optim2 = currentNumber % 100;        //      Нахождение второго и третьего числа (после можно найти только третье число)
    int optim3 = currentNumber % 10;         //      Нахождение третьего числа 
    int rezult = optim1 * 10 + optim3;

    Console.WriteLine(rezult);
    Console.WriteLine();
}
*/     //                                            Второй метод 
Random rand  = new Random();
// int number = rand.Next(100, 1000);
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

Alternativa(number);                    //      Обращение к методу Zadacha9 столько раз сколько хочешь.      

void Alternativa(string currentNumber)     //      f(x)
{
    Console.WriteLine();
    Console.Write(currentNumber[1]); //первый индекс
    Console.Write(currentNumber[2]);
    Console.WriteLine();
    Console.WriteLine(" " + currentNumber[0] + currentNumber[2]);
} 

