import java.util.Arrays;

public class sem_4 {
 public static void main(String[] args) {
  int[] array = new int[] { 3, 2, 4, 3, 3, 1, 5, 3, 3 };
  int val = 3;
  int counter = 0;
  for (int i = 0; i < array.length; i++) {
   if (array[i] != val) {
    array[counter] = array[i];
    array[i] = val;
    counter += 1;
   }
  }
  System.out.println(Arrays.toString(array));







  // еще одно решение преподавателя на два цикла но при этом ничего не ломается
 
  int[] arr = new int[] { 1, 2, 4, 5, 3, 3 }; // 1 2 4 5 3 3 3 3 3
  int value = 3;
  int count = 0;// 4

  for (int i = 0; i < arr.length; i++)
   if (arr[i] != value) {
    arr[count++] = arr[i];
   }

  while (count < arr.length)
   arr[count++] = value;

  // for (int i : arr) {
  // System.out.println(i);
  // }
  System.out.println(Arrays.toString(arr));

 }
}
