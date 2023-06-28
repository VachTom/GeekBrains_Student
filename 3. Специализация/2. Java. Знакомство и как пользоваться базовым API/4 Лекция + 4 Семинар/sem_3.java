/* Реализовать консольное приложение, которое: 
 * 1) Принимает от пользователя и "запоминает" строки.
 * 2) Если введено print, выводит строки так, чтобы последняя веденная
 * была первой в списке, а первая - последней и чистит весь перечень.
 * 
 * qwe
 * [qwe]
 * tre
 * [qwe, tre]
 * zxc
 * [qwe, tre, zxc]
 * print
 * zxc, tre, qwe
 * []
 */

import java.util.LinkedList;
import java.util.Scanner;
import java.util.Stack;

public class sem_3 {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in, "cp866");
  String stroka = sc.nextLine();
  System.out.println("Введите строку:");
  Stack<String> list1 = new Stack<String>();
  while (!stroka.equals("exit")) {
   if (stroka.startsWith("print")) {
    while (!list1.empty()) {
     System.out.println(list1.pop());
    }
   } else {
    list1.add(stroka);
   }
   System.out.println(list1);
   System.out.println("Введите строку:");
   stroka = sc.nextLine();
  }
 }
}