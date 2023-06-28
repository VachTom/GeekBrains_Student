/* Даны два Deque, представляющие два целых числа. Цифры хранятся в обратном порядке и каждый из их узлов содержит одну цифру.
1) Умножьте два числа и верните произведение в виде связанного списка.
2) Сложите два числа и верните сумму в виде связанного списка.
Одно или два числа могут быть отрицательными.

Даны два Deque, цифры в обратном порядке.
[3,2,1] - пример Deque
[5,4,3]- пример второго Deque
1) 123 * 345 = 42 435
Ответ всегда - связный список, в обычном порядке
[4,2,4,3,5] - пример ответа */

import java.util.Random;
import java.util.Scanner;
import java.util.Stack;

public class sem_dz_1 {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in, "cp866");
  System.out.print("Введите размер 1 Deque: ");
  int n1 = sc.nextInt();
  System.out.print("Введите размер 2 Deque: ");
  int n2 = sc.nextInt();

  Stack<Integer> deque1 = DeqStack(n1);
  Stack<Integer> deque2 = DeqStack(n2);

  System.out.println("1 Deque: " + deque1);
  System.out.println("2 Deque: " + deque2);

  System.out.println("Результат: " + DeqStackSum(deque1));
 }

 public static Stack<Integer> DeqStack(int f) {
  Random rand = new Random();
  Stack<Integer> list1 = new Stack<Integer>();
  while (list1.size() < f) {
   int val = rand.nextInt(1, 10);
   list1.add(val);
  }
  return list1;
 }

 public static Stack<Integer> DeqStackSum(Stack deque) {
  int temp = 0;
   while (!deque.empty()) {
    int number = Integer.parseInt();
    
     System.out.println(deque.pop());
     
     System.out.println(deque);
    }
  return deque;
 }

}