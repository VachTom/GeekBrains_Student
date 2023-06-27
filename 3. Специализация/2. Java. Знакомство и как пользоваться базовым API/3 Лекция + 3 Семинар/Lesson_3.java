// file:///C:/Users/wrest/OneDrive/%D0%A0%D0%B0%D0%B1%D0%BE%D1%87%D0%B8%D0%B9%20%D1%81%D1%82%D0%BE%D0%BB/%D0%9E%D0%B1%D1%83%D1%87%D0%B5%D0%BD%D0%B8%D0%B5/%D0%92%D0%B8%D0%B4%D0%B5%D0%BE%D0%9C%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%B0%D0%BB%D1%8B/3.%20%D0%A1%D0%BF%D0%B5%D1%86%D0%B8%D0%B0%D0%BB%D0%B8%D0%B7%D0%B0%D1%86%D0%B8%D1%8F%20%D0%9F%D1%80%D0%BE%D0%B3%D1%80%D0%B0%D0%BC%D0%BC%D0%B8%D1%81%D1%82/2.%20Java.%20%D0%97%D0%BD%D0%B0%D0%BA%D0%BE%D0%BC%D1%81%D1%82%D0%B2%D0%BE%20%D0%B8%20%D0%BA%D0%B0%D0%BA%20%D0%BF%D0%BE%D0%BB%D1%8C%D0%B7%D0%BE%D0%B2%D0%B0%D1%82%D1%8C%D1%81%D1%8F%20%D0%B1%D0%B0%D0%B7%D0%BE%D0%B2%D1%8B%D0%BC%20API/_%D0%9B%D0%B5%D0%BA%D1%86%D0%B8%D1%8F%203.%20%D0%9A%D0%BE%D0%BB%D0%BB%D0%B5%D0%BA%D1%86%D0%B8%D0%B8%20JAVA%20%D0%92%D0%B2%D0%B5%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5.pdf

/* Удобный массив»
Разные способы создания
ArrayList<Integer> list1 = new ArrayList<Integer>();
ArrayList<Integer> list2 = new ArrayList<>();
ArrayList<Integer> list3 = new ArrayList<>(10);
ArrayList<Integer> list4 = new ArrayList<>(list3);


 * Коллекции. Row Type
import java.util.ArrayList;
import java.util.List;
public class Ex002_ArrayList {
 public static void main(String[] args) {
 List list = new ArrayList();
 list.add(2809);
 list.add("string line");
 for (Object o : list) {
 System.out.println(o);
 // Проблема извлечения данных
 }
 }
} // row type java


 * Коллекции. Save Type

import java.util.ArrayList;
import java.util.List;
public class Ex002_ArrayList {
 public static void main(String[] args) {
 List<Integer> list = new ArrayList<Integer>();
 list.add(1);
 list.add(123);
 // list.add("string line");
 for (Object o : list) {
 System.out.println(o);
 // Проблема извлечения данных
 }
 }
}

Коллекции. Save Type
Ошибки на этапе компиляции лучше ошибок времени 
выполнения
Повторное использование кода 

*/