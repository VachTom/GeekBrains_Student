import java.util.Scanner;

public class sem_1 {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in, "cp866"); // эта строчка отвечает за то что бы работать в терминале
  System.out.print("Введите имя: ");
  String name = sc.nextLine();// строчка input
  System.out.printf("Привет, %s", name);
  sc.close();

  // .nextLine() --- считывает строку до перехода
  // .next()      --- считывает строку 
  // .nextInt() --- считывает Число 
 }

 }