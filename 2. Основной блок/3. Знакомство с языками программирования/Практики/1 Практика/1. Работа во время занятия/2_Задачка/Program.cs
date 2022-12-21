/* Напишите программу которая будет выдавать названия дня недели по заданному номеру
// 3 Среда 5 пятница

 Console.Write("Введите № дня недели: ");
    int Number = Convert.ToInt32(Console.ReadLine());
  
    if (Number == 1) Console.Write("Понедельник");
      else if (Number == 2) Console.Write("Вторник");
      else if (Number == 3) Console.Write("Среда");
      else if (Number == 4) Console.Write("Четверг");
      else if (Number == 5) Console.Write("Пятница");
      else if (Number == 6) Console.Write("Суббота");
      else if (Number == 7) Console.Write("Воскресенье");
    else Console.Write("Это уже не день недели");
*/

// Похожа задача на 

int number = Convert.ToInt32(Console.ReadLine());
int count = -number ;
while (count <=  number)
{
    Console.Write(count + "_");
    count++;
}
Console.WriteLine();