/* Написать метод, который принимает массив элементов,
 * помещает их в очередь и выводит на консоль содержимое очереди.
 */

import java.util.LinkedList;
import java.util.Queue;
import java.util.Random;

public class sem_4 {
  public static void main(String[] args) {
    Random rand = new Random();
    int[] arr = new int[10];
    System.out.print("Пожалуйста введите кол-во целых чисел в массиве: ");
    for (int i = 0; i < arr.length; i++) {
      int val = rand.nextInt(-100, 100);
      arr[i] = val;
    }

    System.out.println(inArray(arr));
  }
  public static Queue<Integer> inArray(int[] arr) {
    Queue<Integer> result = new LinkedList<>();
    for (int i : arr) {
      result.add(i);
    }
  return result;
  }
}