import java.util.LinkedList;
import java.util.Scanner;

/* Реализовать консольное приложение, которое:
 * 1) Принимает от пользователья строку вида text
 * 2) Нужно сохранить text в связный список
 * 3) Если введено print~num, выводит строку из позиции num в связном списке и удаляет её из списка.
 * 4) Выход из программы - exit
 */
public class sem_2_print_num {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in, "cp866");
  String stroka = sc.nextLine();
  System.out.println("Введите строку:");
  LinkedList<String> list1 = new LinkedList<String>();
  while (!stroka.equals("exit")) {
   if (stroka.startsWith("print~")) {
    int number = Integer.parseInt(stroka.split("~")[1]);
    list1.remove(number);
   } else {
    list1.add(stroka);
   }
   System.out.println(list1);
   System.out.println("Введите строку:");
   stroka = sc.nextLine();
  }
 }
}