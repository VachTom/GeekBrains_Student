// Дано четное число N (>0) и символы с1 и с2. Написать метод,
// который вернет строку длины N,
// которая состоит из чередубщихся символов с1 и с2, начиная с с1.

import java.util.Scanner;

public class sem_2 {
 public static void main(String[] args) {

  Scanner sc = new Scanner(System.in, "cp866");
  System.out.print("Введите четное число: ");
  int n = sc.nextInt();
  System.out.print("Введите первый символ: ");
  char c1 = sc.next().charAt(0);
  System.out.print("Введите второй символ: ");
  char c2 = sc.next().charAt(0);

  Fs(n, c1, c2);
 }

 public static void Fs(int n, char c1, char c2) {

  String stroka = "";
  StringBuilder sb = new StringBuilder(stroka);

  // System.out.println(sb.toString()); // переводит к строке, как я понимаю
  // конвертация

  if (n % 2 != 0) {
   System.out.println("Ошибка! Пожалуйста введите четное число.");
  } else {
   for (int i = 0; i < n/2; i++) {
    sb.append(c1).append(c2);
   }
    System.out.printf("Релуьтат: %s", sb);

  }
 }
}
