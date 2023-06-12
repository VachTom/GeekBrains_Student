/* Дан массив двоичных чисел, например [1,1,0,1,1,1], 
вывести максимальное количество подряд идущих 1. */

public class sem_2 {
 public static void main(String[] args) {
  int[] ar = new int[] { 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1,0};
  int count = 0;
  int current = 0;

  for (int i = 0; i < ar.length; i++) {
   if (ar[i] == 1) {
    current += 1;
   } else current = 0;

   if (count < current) {
    count = current;
   }
  }
  System.out.printf("Результат: %s", count);
 }
}