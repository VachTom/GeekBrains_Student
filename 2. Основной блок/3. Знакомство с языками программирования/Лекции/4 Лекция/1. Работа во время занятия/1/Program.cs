/* Освоение двухменрных массивов


string[,] table = new string[2, 5];



table[1, 2] = "слово";
for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.WriteLine($"-{ table[rows, columns]}-");
    }
}



*/

void PrintArray(int[,] matr)
{
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            Console.Write($"{matr[x, y]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)

{
    for (int x = 0; x < matr.GetLength(0); x++)
    {
        for (int y = 0; y < matr.GetLength(1); y++)
        {
            matr[x,y] = new Random().Next(1,10); //[1, 10)
        }
     }
}

int[,] matrix = new int[4, 7];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
matrix[3, 5] = 39;
PrintArray(matrix);