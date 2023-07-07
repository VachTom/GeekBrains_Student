/* 1. Напишите метод, который заполнит массив из 99 элементов 
случайными цифрами от 0 до 50.
2. Создайте метод, в который передайте заполненый выше массив и с 
помощью Set вычислите % уникальных значений в данном массиве 
и верните его в виде числа с плавающей запятой. 
Для вычесления процента используйте формулу: 
% уникальных чисел = кол-во уникальных чисел * 100 / общее кол-во чисел в массиве
*/

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashSet;
import java.util.Random;
import java.util.Set;

public class sem_1 {
 public static ArrayList<Integer> Arr1() {
  ArrayList<Integer> ArrList = new ArrayList<Integer>();
  Random rnd = new Random();
  for (int i = 0; i < 99; i++) {
   int val = rnd.nextInt(0, 50);
   ArrList.add(0, val);
  }
  // System.out.println(ArrList);
  return ArrList;
 }

 public static float unic_counter(ArrayList Arr1) {
  Set<Integer> set = new HashSet<>();
  set.addAll(Arr1);
  return (float) set.size() / Arr1.size() * 100;
 }
 
 public static void main(String[] args) {
System.out.println(Arr1());
  System.out.println(unic_counter(Arr1()));
 }

}



/* 
// 1. Напишите метод, который заполнит массив из 99 элементов случайными цифрами от 0 до 50.
// 2. Создайте метод, в который передайте заполненный выше массив и с помощью Set вычислите процент уникальных значений
// в данном массиве и верните его в виде числа с плавающей запятой.
// Для вычисления процента используйте формулу:
// процент уникальных чисел = количество уникальных чисел * 100 / общее количество чисел в массиве.

public class sample_1 {
    public static void main(String[] args) {
        int range = 50;
        int size = 99;
        Integer[] array_Task = fillArray(size, range);
        System.out.println(Arrays.toString(array_Task));
        System.out.println(unic_counter(array_Task));
    }
    public static Integer[] fillArray(int size, int range) {
        Integer[] mas = new Integer[size];
        Random rand = new Random();
        for (int i = 0; i < size; i++) {
            mas[i] = rand.nextInt(range);
        }
        return mas;
    }
    public static float unic_counter(Integer[] array) {
        Set<Integer> set = new HashSet<>(Arrays.asList(array));
        set.addAll(Arrays.asList(array));
        return (float)set.size() / array.length * 100;
    }
} */