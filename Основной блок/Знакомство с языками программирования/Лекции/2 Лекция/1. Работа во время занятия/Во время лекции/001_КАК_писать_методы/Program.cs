Random rand  = new Random();
int number = rand.Next(10, 100);



Zadacha9(number);              
                                     // Обращение к методу Zadacha9 столько раз сколько хочешь. 
number = rand.Next(10, 100);


Zadacha9(number);              
                                     // Обращение к методу Zadacha9 столько раз сколько хочешь. 
number = rand.Next(10, 100);


Zadacha9(number);              
                                     // Обращение к методу Zadacha9 столько раз сколько хочешь. 
number = rand.Next(10, 100);





void Zadacha9(int currentNumber) // f(x)
{

    Console.WriteLine(number);
    int optim = number/10;
    int optim2 = number%10;  

    

    if (optim > optim2) Console.WriteLine(optim);
    else if (optim < optim2) Console.WriteLine(optim2);
    else Console.WriteLine("Числа равны");

    Console.WriteLine();

}