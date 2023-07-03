// Создать структуру для хранения Номеров паспортов и Фамилий сотрудников организации.

// 123456 Иванов
// 321456 Васильев
// 234561 Петрова
// 234432 Иванов
// 654321 Петрова
// 345678 Иванов
// Вывести данные по сотрудникам с фамилией Иванов.

import java.util.HashMap;
import java.util.Map;

/**
 * sem_1
 */
public class sem_1 {

 public static void main(String[] args) {
  Map<Integer, String> passport = new HashMap<>();
  passport.put(123456, "Иванов");
  passport.put(321456, "Васильев");
  passport.put(234561, "Петрова");
  passport.put(234432, "Иванов");
  passport.put(654321, "Петрова");
  passport.put(345678, "Иванов");
  for (var item : passport.entrySet()) {
   if (item.getValue().equals("Иванов")) {
    System.out.printf("%s: %s \n", item.getKey(), item.getValue());
   }
  }
  // Второй способо но через ключ keySet()
  for (Integer item2 : passport.keySet()) {
   if (passport.get(item2).equals("Иванов")) {
    System.out.printf("\n %s: %s \n", item2, passport.get(item2));

   }
  }
 }
}