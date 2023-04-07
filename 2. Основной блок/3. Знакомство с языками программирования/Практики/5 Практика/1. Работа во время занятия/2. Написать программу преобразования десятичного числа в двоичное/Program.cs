/*Написать программу преобразования десятичного числа в двоичное*/
int RedInt()
{
    Console.Write("Введите число: ");
    return int.Parse(Console.ReadLine()!);
}

int decimalNum = RedInt();
int decimalNum2 = decimalNum;
int NumLength = 0;

while (decimalNum2 > 0)
{
    decimalNum2 /=2;
    NumLength++;
}
Console.WriteLine(NumLength);

int[] array = new int [NumLength];
for (int j = 0; decimalNum>0; j++)
{
    array[j] = decimalNum%2;
    decimalNum/=2;
}
for (int i = array.Length-1; i >0 ; i--)
{
    Console.Write(array[i]);
}
