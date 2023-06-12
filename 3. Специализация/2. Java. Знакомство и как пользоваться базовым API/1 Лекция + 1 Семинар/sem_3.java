/* Дан массив nums = [3,2,4,3,3,1,5,3,3] и число val = 3.
Если в массиве есть числа, равные заданному, нужно перенести эти элементы в конец массива.
Таким образом, первые несколько (или все) элементов массива должны быть отличны от заданного, а остальные - равны ему.

[2 4 1 5 3 3 3 3 3]

Работать разрешается только с 1 массивом. */

public class sem_3 {
 public static void main(String[] args) {
  int[] arr = new int[] { 3, 2, 4, 3, 3, 1, 5, 3, 3 };

  System.out.print("3 2 4 3 3 1 5 3 3");
  System.out.println();
  int val = 3;
  int count = 0;

  for (int i = 0; i < arr.length; i++) {
   if (arr[i] == val) {
    for (int j = i; j < arr.length; j++) {

     // count = ;

     arr[j] = ;

    }
    System.out.print(arr + " ");
   }
  }
 }
}